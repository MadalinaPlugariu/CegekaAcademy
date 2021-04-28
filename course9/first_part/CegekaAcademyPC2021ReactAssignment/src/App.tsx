import React from 'react';
import { BrowserRouter } from 'react-router-dom';
import './App.css';
import Nav from './components/Nav';
import Main from './components/Main';
function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Nav />
        <Main />
      </BrowserRouter>
    </div>
  );
}

export default App;
