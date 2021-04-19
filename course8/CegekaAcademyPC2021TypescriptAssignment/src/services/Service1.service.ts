import movies from '../data/movies.json';
import seats from '../data/seats.json';
import { Movie } from '../models';
import {MovieHall} from '../models';

export class Service1 {

    private _movieList: Movie[];
    private _hallSeats: MovieHall[];

    constructor() {
        this._movieList = movies;
        this._hallSeats = seats;
    }   

    /**
     * getMovies
     * TODO: define and specify a return type. Normally, typescript will infere it
     * but for the purposes of this exercise, let's specify it 
     */
    public getMovies(): Movie[] {
        console.log(`Retrieving movies data: ${JSON.stringify(this._movieList)}`);
        return this._movieList;
    }
    public getSeats(): MovieHall[] {
        console.log(`Retrieving seats data: ${JSON.stringify(this._hallSeats)}`);
        return this._hallSeats;
    }


    public getAvailableSeats(titlu: string): MovieHall[]{
        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);

        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);

        for( var k in myMoviesP){
            if(myMoviesP[k].title == titlu) {
                console.log(`Number of available seats are: ${myMoviesP[k].locuri_disponibile}`);
                for(var i=0 ;i<10; i++){
                    if(mySeatsP[0].loc_rezervat[i] == 0)
                       console.log(`Available seats: ${mySeatsP[0].loc[i]}`);
                }
            }
        }
        return this._hallSeats;
    }


    public makeReservation(titlu : string, nr_loc : number){
        console.log("Make a reservation");

        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);

        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);

        var count=0;
        for( var k in myMoviesP){
            if(myMoviesP[k].title == titlu) {
                console.log(`Found it: ${myMoviesP[k].title}`);
                if(myMoviesP[k].locuri_disponibile > 0)
                    if(myMoviesP[k].locuri_ocupate[nr_loc] == 0 ){
                        myMoviesP[k].locuri_ocupate[nr_loc] = 1;
                        mySeatsP[0].loc_rezervat[nr_loc] = 1;
                        myMoviesP[k].locuri_disponibile -= 1;
                    }
                console.log(`Reservation added at: ${myMoviesP[k].title}, at seat nr: ${ mySeatsP[0].loc[nr_loc-1]}`);
                count = 1;
            }
        }
        if(count == 0 ){
            console.log("Movie not found");
        }

        return this._movieList;
    }

    public cancelReservation(titlu: string, nr_loc : number){
        console.log("Cancel reservation");

        const myMovies = JSON.stringify(this._movieList);
        var myMoviesP = JSON.parse(myMovies);

        const mySeats = JSON.stringify(this._hallSeats);
        var mySeatsP = JSON.parse(mySeats);

        var count=0;
        for( var k in myMoviesP){
            if(myMoviesP[k].title == titlu) {
                console.log(`Found it: ${myMoviesP[k].title}`);
                if(mySeatsP[0].loc_rezervat[nr_loc] == 1){
                    mySeatsP[0].loc_rezervat[nr_loc] = 0;
                    myMoviesP[k].locuri_ocupate[nr_loc] = 0;
                    myMoviesP[k].locuri_disponibile += 1 ;
                }
                console.log(`Reservation canceled for: ${myMoviesP[k].title}, at seat nr: ${ mySeatsP[0].loc[nr_loc-1]}`);
                count = 1;
            }
        }
        if(count == 0 ){
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
    public deleteMovieExample() {
        console.log(`deleting last movie... ${JSON.stringify(movies)}`);
        // Remove the last movie from the in-memory collection
        movies.pop();
        return movies;
    }
}