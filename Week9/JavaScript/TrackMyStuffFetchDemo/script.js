//Now, we are going to listen for the DOMContentLoaded event to start off our JS file
document.addEventListener('DOMContentLoaded', () => {

    //Im going to select my containers and buttons at the top of my JS file, within that
    //DOMContentLoaded listener lambda
    //Selecting my div containers, by their id
    const loginContainer = document.getElementById('login-container');
    const userContainer = document.getElementById('user-container');

    //Select my elements, such as buttons and text to update 
    const loginButton = document.getElementById('login-button');
    const logoutButton = document.getElementById('logout-button');
    const welcomeMessage = document.getElementById('welcome-message');
    const itemsList = document.getElementById('items-list');

    //TODO - Check if a user is already logged in


    //Listening for a click event on our login button, that will send an HTTP request to GET
    //a user from our API using Fetch
    loginButton.addEventListener('click', async () => {

        //When the user clicks the login button, we enter this event listener.
        //We want to take whatever username string they entered in our text input and store it here
        const username = document.getElementById('username').value;

        if (username) {

            //use a try-catch to handle any sort of errors that may arise during the handling of
            //our HTTP request
            try {

                //Create something to hold our response that we get back from our API
                const response = await fetch(`http://localhost:5192/Users/${username}`);
                
                //Once we send the request, and get the reply, we will store that user object in our const user
                const user = await response.json();

                //Im going to store the user locally on the browser so that if the page reloads, I don't have to
                //log back in every single time

                //We call localStorage.setItem(), give it a string as a key, and then the value will be the json
                //string representation of our user we got from the API above.
                localStorage.setItem('user', JSON.stringify(user));

                //Calling our UI update function
                updateUIForLoggedInUser(user);

                //Here im going to add a call to a function that will update the UI if a user is found

            } catch (error) {
                console.error('Error logging in: ', error);
            }
        }//End if to check username has anything in it
    });//end of the loginButton event listener

    //TODO - add logout button event listener

    //This function will update the UI for my logged in user, once they are found
    function updateUIForLoggedInUser(user) {
        //Selecting my loginContainer div, and updating so that its style is display: none;
        loginContainer.style.display = 'none';
        //Updating the welcome message based on the username
        welcomeMessage.textContent = `Welcome ${user.userName}!`;
        //Un-hiding the user container
        userContainer.style.display = 'block';

        //So when we update the UI for a logged in user, we are going to call our fetchUserItems function
        //and grab their items for them
        fetchUserItems(user.userId);

    };//end updateUIForLoggedInUser

    //Function that fetches user items from our backend, and then calls the renderUserItems function
    //to reflec the changes on our page
    async function fetchUserItems(userId) {
        try{
            //Sending a request for our logged in user's items based on their userId
            const response = await fetch(`http://localhost:5192/Items?userId=${userId}`);
            
            //Store the list of items - parsing the response into our const items
            const items = await response.json();

            //Call to a function to render our items in our HTML that our browser sees
            renderItemsList(items);

        }catch (error) {
            console.error('Error fetching items: ', error);
        }



    };//end FetchUserItems

    //Here is a function that will use DOM manipulation to display our list of items on our page
    function renderItemsList(items) {
        //set the innerHTML of our itemsList to an empty string
        itemsList.innerHTML = '';

        //For each item in our items list, we will update the HTML to display that item within
        //the ol element of our html file
        items.forEach(item => {
            //For each item, we create an li (list item) element within our ordered list 
            const listItem = document.createElement('li');

            //We give the list item text content related to our item that we want to display
            //We use dot notation to access the fields of our item
            //We need the fields to match with the json that comes back, so this is case sensitive
            listItem.textContent = `${item.category} - ${item.description} - $${item.originalCost}`;
            
            //Once we've created our list item, and given it relevant text content from our json return
            //We need to actually stick it into the list
            itemsList.appendChild(listItem);
        });

    };//end renderItemsList



});// End DOMContentLoaded Listener