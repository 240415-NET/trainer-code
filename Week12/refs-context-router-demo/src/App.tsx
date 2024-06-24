import React from 'react';
import NavBar from './components/NavBar';
import Home from './components/Home';
import About from './components/About';
import Dashboard from './components/Dashboard';
//Im going to import my router, that I downloaded with that npm install
import { BrowserRouter, Route, Routes } from 'react-router-dom';

function App() {
  return (
    <BrowserRouter> 
      <NavBar />
      <Routes>
        <Route path="/" Component={Home}/> 
        <Route path="/about" Component={About}/>
        <Route path="/dashboard" Component={Dashboard}/>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
