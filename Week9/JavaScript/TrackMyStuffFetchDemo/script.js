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

                //Here im going to add a call to a function that will update the UI if a user is found

            } catch (error) {
                console.error('Error logging in: ', error);
            }


        }//End if to check username has anything in it




    });//end of the loginButton event listener



});// End DOMContentLoaded Listener