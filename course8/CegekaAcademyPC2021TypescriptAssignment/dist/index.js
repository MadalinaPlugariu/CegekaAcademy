"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const services_1 = require("./services");
const port = Number(process.env.PORT || 3000);
const logRequest = (req, res, next) => {
    console.log(`${req.method} - ${req.originalUrl} ${JSON.stringify(req.params)}`);
    console.log(`${res.statusCode}`);
    next();
};
const app = express_1.default();
app.use(logRequest);
app.get("/", (req, res) => {
    res.send("Hello Typescript Assignment");
});
app.get("/movies", (req, res) => {
    let service1 = new services_1.Service1();
    let response = service1.getMovies();
    res.send(response);
});
app.get("/seats", (req, res) => {
    let service2 = new services_1.Service1();
    let response = service2.getSeats();
    res.send(response);
});
app.get("/availableSeats", (req, res) => {
    let service2 = new services_1.Service1();
    let response = service2.getAvailableSeats("Before Sunset");
    res.send(response);
});
app.post("/reserve", (req, res) => {
    let service3 = new services_1.Service1();
    let response = service3.makeReservation("Before Sunset", 7);
    res.send(response);
});
app.post("/cancelResation", (req, res) => {
    let service4 = new services_1.Service1();
    let response = service4.cancelReservation("Before Sunset", 7);
    res.send(response);
});
app.post("/deleteMovie", (req, res) => {
    let service1 = new services_1.Service1();
    let response = service1.deleteMovieExample();
    res.send(response);
});
app.listen(port, () => {
    console.log(`server started on port ${port}`);
});
