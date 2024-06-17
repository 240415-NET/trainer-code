import React from 'react';
import logo from './logo.svg';
import './App.css';

//This is our root component called App. We will create our own components that we then nest inside of or call 
//from App later on. 
//Notice that App is a FUNCTIONAL component. Its a TS function that returns HTML (with some slight syntax differences)
//that is then rendered in the browser. 
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
