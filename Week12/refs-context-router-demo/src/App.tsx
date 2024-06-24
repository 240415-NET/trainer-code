import React from 'react';
import NavBar from './components/NavBar';
import Home from './components/Home';
import About from './components/About';
import Dashboard from './components/Dashboard';
//Im going to import my router, that I downloaded with that npm install
import { BrowserRouter } from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
      <NavBar />

    </BrowserRouter>
  );
}

export default App;
