//First off, I will import React (so I get access to all the React library methods, may or may not use them)
//I also import something called useState. useState is a "hook". 
//Hooks allow functional components to remember and pass information related to their "state"
//State referring to changes or updates based on user interaction
import React, { useState } from 'react';

//So here, we declare our Functional component definition. We can use this syntax or the traditional 
//"function MyFunctionComponent = {} " syntax. Whatever is easier to wrap your head around
//We want to bring in the React.FC
function FunctionalCounter() {

    //Declare a variable to hold a count (the amount of times the user clicks a button)
    //this will track our component's "state"
    const [count, setCount] = useState(0);

    //Create a function that will increment our count
    const increment = () => setCount(count + 1);

    //Create a function that will decrement the count
    const decrement = () => setCount(count - 1);

    //Once we create our variables for state, bring in whatever arguments from outside our
    //component we need, create functions to do things based on those inputs, etc
    //We will create a return.
    //This return is where our HTML that will be rendered will be written
    return (
        <div>
            <h3>This is my functional counting component</h3>
            {/* This is a comment inside of my TSX file's HTML 
            This will not render.
            Notice below, we have a slight change to our break tag with the ending forward slash
            HTML written inside of a react component does not like self closing tags. There are some other
            slight syntax differences that we will encounter as we use react*/}
            <br /> 
            {/* Inside of return for my component, it expects HTML. We can "break out" of our HTML and call upon 
            TypeScript by using these braces {}*/}
            <p>Count: {count}</p>
            <button onClick={increment}>Increment the count!</button>
            <button onClick={decrement}>Decrement the count :c </button>
        </div>
    );

}


//Whatever syntax for writing out TypeScript function for our component, we must remember to export it at the end
//This is what will make it visible across our application
export default FunctionalCounter;