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
        
      </header>
    </div>
  );
}

export default App;
