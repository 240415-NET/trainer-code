import React from 'react';
import NavBar from './components/NavBar';
import Home from './components/Home';
import About from './components/About';
import Dashboard from './components/Dashboard';
//Im going to import my router, that I downloaded with that npm install
import { BrowserRouter, Route, Routes } from 'react-router-dom';

//To give child components access to a context, we have to wrap them in the ContextProvider
//In our Home (and in any other child components of App.tsx that want to see the context) they import 
//the context itself
//In our App.tsx parent, we import the context provider
import MessageContextProvider from './context/MessageContext';

function App() {
  return (
    <MessageContextProvider>
      <BrowserRouter>
        <NavBar />
        <Routes>
          <Route path="/" Component={Home} />
          <Route path="/about" Component={About} />
          <Route path="/dashboard" Component={Dashboard} />
        </Routes>
      </BrowserRouter>
    </MessageContextProvider>
  );
}

export default App;
