import React, {useState, useEffect} from 'react';
import logo from './logo.svg';
import Login from './components/Login';
import UserInfo from './components/UserInfo';
import './App.css';

function App() {

  const [userObject, setUserObject] = useState<any>(null); //Storing our user object, setting it to null if nobody is logged in

    //Here, we will use our useEffect hook that is built into react and imported above 
    //to check localStorage and see if there is a user object stored in there
    useEffect(() => {
      //First, we will create a variable to store our user (if they exist!)
      //We call JSON.parse() to try to create an object based on the user json in local storage
      //If the user exists, they are parsed and brought in
      //If they DO NOT exist, we will store a null inside of our userFromLocalStorage variable
      const userFromLocalStorage = JSON.parse(localStorage.getItem('user') || 'null');
      
      //if there is an actual value (so, we found a user after all) in userFromLocalStorage, 
      //we will store that in our state, by calling the setUserObject "setter" that we declared above
      if (userFromLocalStorage) {
          setUserObject(userFromLocalStorage);
      }
      //If you call useState from within useEffect, remember to pass in an empty array before closing the final parenthesis
      //This is due to the behavior of useEffect
  }, []);


  return (
    <div className="App">
      {/* <Login setUser={setUserObject}/> */}
      {/* Here, we've even shifted the conditional rendering to App.tsx. The code below,
      checks to see if our userObject in App.tsx's state exists, if it does, we don't render the login component */}
      {!userObject && <Login setUserFromApp={setUserObject}/>}
      {/* <UserInfo loggedInUser={userObject}/> */}
      {userObject && <UserInfo loggedInUserFromApp={userObject}/>}
    </div>
  );
}

export default App;
