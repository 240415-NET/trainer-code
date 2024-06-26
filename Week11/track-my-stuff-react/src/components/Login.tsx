//Importing useState, so that our component can remember it's state as the user uses our app,
//makes changes, calls our backend and stores things, etc
//I will also import another hook called "useEffect"
//useEffect will be used to interact with localStorage, which is "external" to react
//useEffect can be used to interact with all sorts of external systems, like other front end libraries,
//animation libraries, really whatever you'd need - from within our components
import React, { useState, useEffect} from 'react';


//Creating an interface to hold my props 
interface LoginProps {
    setUserFromApp: (user:any) => void;
}

//Within my function Login(), which is my react functional component for user log in stuff,
//I will write my log in logic including my localStorage logic and API calls to my backend.
//Updated my Login functional component to take a prop from App.tsx
//In this case, the prop is the state setter function FROM App.tsx.
//I can now call this function within Login. When I do, the state in App.tsx will be updated.
function Login({setUserFromApp} : LoginProps) {

    //First, I will initialize our state when a user first arrives at our application
    //We can think of username as our "field" and setUsername as our "setter"
    const [username, setUsername] = useState(''); //Storing our username input string, setting it to an empty string
    //const [userObject, setUserObject] = useState<any>(null); //Storing our user object, setting it to null if nobody is logged in
    


    // //Here, we will use our useEffect hook that is built into react and imported above 
    // //to check localStorage and see if there is a user object stored in there
    // useEffect(() => {
    //     //First, we will create a variable to store our user (if they exist!)
    //     //We call JSON.parse() to try to create an object based on the user json in local storage
    //     //If the user exists, they are parsed and brought in
    //     //If they DO NOT exist, we will store a null inside of our userFromLocalStorage variable
    //     const userFromLocalStorage = JSON.parse(localStorage.getItem('user') || 'null');
        
    //     //if there is an actual value (so, we found a user after all) in userFromLocalStorage, 
    //     //we will store that in our state, by calling the setUserObject "setter" that we declared above
    //     if (userFromLocalStorage) {
    //         setUserObject(userFromLocalStorage);
    //     }
    //     //If you call useState from within useEffect, remember to pass in an empty array before closing the final parenthesis
    //     //This is due to the behavior of useEffect
    // }, []);

    //Here, we will create a function that we will call when our login button is clicked 
    //that will make the fetch request to our API
    async function handleUserLogin() {
        //First, we check to see if the username in our state is still null
        //When the user clicks our login button, the username should be stored in our state
        if (username) {
            //If username is NOT empty or null, we will use a try-catch to send our GET request
            try{
                //Fetch GET to our API for our user 
                const response = await fetch(`http://localhost:5192/Users/${username}`);

                //Parse our response body as json, we must remember to await this as it is asynchronous
                const userFromAPI = await response.json(); 

                //Storing our userObject data. We need to store it in localStorage (browser)
                //and we need to store it in our State for our component's use
                localStorage.setItem('user', JSON.stringify(userFromAPI));
                //setUserObject(userFromAPI);
                //Calling the setUser function we took in as a prop, now that App.tsx is managing the user state
                setUserFromApp(userFromAPI);

            } catch (error) { //If the fetch goes wrong, we will send the error message to the console like before
                console.error('Error logging in: ', error);
            }

        }//end if-block to check if username is still empty
    }//end handleUserLogin()

  //Here in the return, we will render what the User will see, as well as call any of our logic written above
  //We will use conditional rendering in our return. IF the user is logged in, we will render NOTHING for our login
  //component. If a user is NOT logged in, we will actually render the login form

  //if NOT userObject, using the logical not (!) operator
  return (
    <div id='login-container'>
        <h2>Login</h2>
        <input 
            type='text' 
            id='username'
            placeholder='username'
            value={username}
            onChange={(userNameFromInputField) => setUsername(userNameFromInputField.target.value)}
        />{/*Again, we need to close our normally self closing tags for React*/}
        <br />
        {/*This is our login button. When it is clicked, we will call handleUserLogin(), from above*/}
        <button onClick={handleUserLogin}>Login</button>
    </div>
  ) //: null; //If a userObject is found, if userObject IS NOT NULL, we render null (nothing at all)
  //We do not want this component rendering if we have a logged in user
}

export default Login;