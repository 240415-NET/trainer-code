import React from 'react';
import logo from './logo.svg';
import './App.css';

//In order to call a component and it's functionality as well as render it from inside of another component,
//we will need to import it. So the component exports itself to make itself available for import across our app
import FunctionalCounter from './components/FunctionalCounter';

//This is our root component called App. We will create our own components that we then nest inside of or call 
//from App later on. 
//Notice that App is a FUNCTIONAL component. Its a TS function that returns HTML (with some slight syntax differences)
//that is then rendered in the browser. 
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>React Counter Functional-Class Demo</h1>
        {/* Here we include our functional component */}
        <FunctionalCounter />
      </header>
    </div>
  );
}

export default App;
