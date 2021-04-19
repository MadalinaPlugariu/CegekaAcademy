import express, {Application, Request, Response, NextFunction} from 'express';
import { Service1 } from './services';

const port = Number(process.env.PORT || 3000);

const logRequest = (req: Request, res: Response, next: NextFunction) => {
  console.log(`${req.method} - ${req.originalUrl} ${JSON.stringify(req.params)}`);
  console.log(`${res.statusCode}`);
  next();
}

const app: Application = express();
app.use(logRequest);

app.get( "/", (req, res) => {
    res.send( "Hello Typescript Assignment" );
});

app.get( "/movies", (req, res) => {
  let service1 = new Service1();
  let response = service1.getMovies();
  res.send(response);
});

app.get( "/seats", (req, res) => {
  let service2 = new Service1();
  let response = service2.getSeats();
  res.send(response);
});

app.get( "/availableSeats", (req, res) => {
  let service2 = new Service1();
  let response = service2.getAvailableSeats("Before Sunset");
  res.send(response);
});

app.post( "/reserve", (req, res) => {
  let service3 = new Service1();
  let response = service3.makeReservation("Before Sunset", 7);
  res.send(response);
});

app.post( "/cancelReservation", (req, res) => {
  let service4 = new Service1();
  let response = service4.cancelReservation("Before Sunset", 7);
  res.send(response);
});



app.post( "/deleteMovie", (req, res) => {
  let service1 = new Service1();
  let response = service1.deleteMovieExample();
  res.send(response);
});

app.listen(port, () => {
    console.log(`server started on port ${port}`);
});