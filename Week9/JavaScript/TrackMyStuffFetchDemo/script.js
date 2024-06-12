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

    //These elements belong to my add item form
    const itemForm = document.getElementById('add-item-form');
    const itemCategory = document.getElementById('new-item-category');
    const itemCost = document.getElementById('new-item-cost');
    const itemDate = document.getElementById('new-item-date');
    const itemDescription = document.getElementById('new-item-description');
    const submitItemFormButton = document.getElementById('submit-item-button');

    //Checking if a user is already logged in
    //First, im going to create something to hold my logged in user (if they exist, otherwise its null)
    const storedUser = JSON.parse(localStorage.getItem('user'));
    if(storedUser) { //if storedUser is not empty
       updateUIForLoggedInUser(storedUser);
    }

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

    //This will fire off when a user is logged in AND THEN chooses to log out via our logout button
    logoutButton.addEventListener('click', () => {
        //Upon logout, we get rid of the localStorage item with the key "user"
        localStorage.removeItem('user');

        //We unhide the login-container div
        loginContainer.style.display = 'block';

        //We hide the user-container div
        userContainer.style.display = 'none';
    });//end of the logoutButton event listener

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

    //Adding a listener for the submission of my new item form
    itemForm.addEventListener('submit', async (event) => {
        //This tells our page to ignore the default behavior of the form submission event
        event.preventDefault()

        //Bringing in the userId that is stored in our localStorage if a user is logged in
        const loggedInUserId = JSON.parse(localStorage.getItem('user')).userId;
        
        if(userId) {
            //here we will create the item object in our Javascipt that will eventually be translated to JSON and sent off
            //to our backend API
            const newItem = {
                userId: loggedInUserId,
                itemId: "00000000-0000-0000-0000-000000000000",
                category: itemCategory.value,
                originalCost: parseFloat(itemCost.value), //Parsing this one into a decimal number
                purchaseDate: itemDate.value,
                description: itemDescription.value
            };

            //Here we will use Fetch to send our POST request to our API, notice how there are some additional steps
            //required versus a GET request using fetch.
            try{

                //Here we use fetch to create our request object and then send it off to our API as a POST
                const itemPostResponse = await fetch(`http://localhost:5192/Item`, {
                    method: 'POST',
                    headers: {
                        'Content-Type' : 'application/json'
                    },
                    body: JSON.stringify(newItem)
                });


            } catch (error) {
                console.error('Error adding item: ', error)
            }

        }

    });


});// End DOMContentLoaded Listener