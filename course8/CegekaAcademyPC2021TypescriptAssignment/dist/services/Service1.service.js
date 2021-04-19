"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.Service1 = void 0;
const movies_json_1 = __importDefault(require("../data/movies.json"));
const seats_json_1 = __importDefault(require("../data/seats.json"));
class Service1 {
    constructor() {
        this._movieList = movies_json_1.default;
        this._hallSeats = seats_json_1.default;
    }
    getTitle() {
    }
    /**
     * getMovies
     * TODO: define and specify a return type. Normally, typescript will infere it
     * but for the purposes of this exercise, let's specify it
     */
    getMovies() {
        console.log(`Retrieving movies data: ${JSON.stringify(this._movieList)}`);
        return this._movieList;
    }
    getSeats() {
        console.log(`Retrieving seats data: ${JSON.stringify(this._hallSeats)}`);
        return this._hallSeats;
    }
    getAvailableSeats(titlu) {
        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);
        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);
        for (var k in myMoviesP) {
            if (myMoviesP[k].title == titlu) {
                console.log(`Number of available seats are: ${myMoviesP[k].locuri_disponibile}`);
                for (var i = 0; i < 10; i++) {
                    if (mySeatsP[0].loc_rezervat[i] == 0)
                        console.log(`Available seats: ${mySeatsP[0].loc[i]}`);
                }
            }
        }
        return this._hallSeats;
    }
    makeReservation(titlu, nr_loc) {
        console.log("Make a reservation");
        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);
        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);
        var count = 0;
        for (var k in myMoviesP) {
            if (myMoviesP[k].title == titlu) {
                console.log(`found it: ${myMoviesP[k].title}`);
                if (myMoviesP[k].locuri_disponibile > 0)
                    if (myMoviesP[k].locuri_ocupate[nr_loc] == 0) {
                        myMoviesP[k].locuri_ocupate[nr_loc] = 1;
                        mySeatsP[0].loc_rezervat[nr_loc] = 1;
                        myMoviesP[k].locuri_disponibile -= 1;
                    }
                console.log(`reservation added at: ${myMoviesP[k].title}, on the seat: ${mySeatsP[0].loc[nr_loc - 1]}`);
                count = 1;
            }
        }
        if (count == 0) {
            console.log("Movie not found");
        }
        return this._movieList;
    }
    cancelReservation(titlu, nr_loc) {
        console.log("Cancel reservation");
        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);
        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);
        var count = 0;
        for (var k in myMoviesP) {
            if (myMoviesP[k].title == titlu) {
                console.log(`Found it: ${myMoviesP[k].title}`);
                if (mySeatsP[0].loc_rezervat[nr_loc] == 1) {
                    mySeatsP[0].loc_rezervat[nr_loc] = 0;
                    myMoviesP[k].locuri_ocupate[nr_loc] = 0;
                    myMoviesP[k].locuri_disponibile += 1;
                }
                console.log(`Reservation canceled for: ${myMoviesP[k].title}, at seat nr: ${mySeatsP[0].loc[nr_loc - 1]}`);
                count = 1;
            }
        }
        if (count == 0) {
            console.log("Movie not found");
        }
        return this._movieList;
    }
    /**
     * This is merely an example of how to edit the test data loaded in-memory
     * from the local .json file.
     * @returns The updated list of movies
     * TODO: remove this method. It was simply added for demonstrative purposes.
     */
    deleteMovieExample() {
        console.log(`deleting last movie... ${JSON.stringify(movies_json_1.default)}`);
        // Remove the last movie from the in-memory collection
        movies_json_1.default.pop();
        return movies_json_1.default;
    }
}
exports.Service1 = Service1;
