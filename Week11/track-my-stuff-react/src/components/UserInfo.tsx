import React, { useState, useEffect} from 'react'
//If I have a child component (that will only be rendered from within it's parent)
//I will import it here, the same way that i've been importing things to render within App.tsx
import ItemList from './ItemList';


function UserInfo() {

    //Creating a spot in our component's state to hold the logged in user that we pull from localStorage
    const [userFromLocalStorage, setUser] = useState<any>(null);
    //This time, we will set the itemList to be of type "any[]", so that our state knows to store
    //a array of objects for us. We ten initialize it to an empty array.
    const [itemListFromAPI, setItemList] = useState<any[]>([]);

    //useEffect to check local storage for a logged-in user
    useEffect(() => {
        //Storing our user pulled from localStorage
        const storedUser = JSON.parse(localStorage.getItem('user') || 'null');
        if (storedUser) {
            setUser(storedUser);
        }
    }, []); //Empty array of dependencies for useEffect, otherwise this will fire off forever

    //Function to fetch a user's item list from the API
    async function fetchUserItems(userId: string) {
        try{
            //Fetch to get the items list for the logged in user
            const response = await fetch(`http://localhost:5192/Items?userId=${userId}`);
            const itemList = await response.json();

            //Call the setItemList "setter" for our state, to store our item list there
            setItemList(itemList);
        }catch (error) {
            console.error('Error fetching user items: ', error)
        }


    }//end fetchUserItems



    //Using conditional rendering via a ternary operation
    //if userFromLocalStorage has a value (i.e., is not null) we render this component
    //otherwise, (i.e. before someone has logged in at all) it is not rendered on our page
  return userFromLocalStorage ? (
    <div id="user-container">
        <h2 id="welcome-message">Welcome {userFromLocalStorage.userName} </h2>
        <br />
        <h4>Your items:</h4>
        <ItemList />
    </div>
  ) : null; //Render nothing if a user is not currently logged in
}

export default UserInfo