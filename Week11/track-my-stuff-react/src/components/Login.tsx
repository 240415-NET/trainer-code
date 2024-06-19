//Importing useState, so that our component can remember it's state as the user uses our app,
//makes changes, calls our backend and stores things, etc
//I will also import another hook called "useEffect"
//useEffect will be used to interact with localStorage, which is "external" to react
//useEffect can be used to interact with all sorts of external systems, like other front end libraries,
//animation libraries, really whatever you'd need - from within our components
import React, { useState, useEffect} from 'react';


//Within my function Login(), which is my react functional component for user log in stuff,
//I will write my log in logic including my localStorage logic and API calls to my backend.
function Login() {

    //First, I will initialize our state when a user first arrives at our application
    //We can think of username as our "field" and setUsername as our "setter"
    const [username, setUsername] = useState(''); //Storing our username input string, setting it to an empty string
    const [userObject, setUserObject] = useState<any>(null); //Storing our user object, setting it to null if nobody is logged in

    


  //Here in the return, we will render what the User will see, as well as call any of our logic written above
  return (
    <div>Login</div>
  )
}

export default Login;