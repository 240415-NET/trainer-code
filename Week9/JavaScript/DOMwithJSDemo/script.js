//This will be our javascript file
//It is attached to our HTML file via a script tag at the bottom of the body element.

//So, first we have to wait for the DOM to fully finish loading. 
//Inside of our javascript file, we can reference all the HTML (and the DOM structure) of
//our index.html, using the "document" object. We don't have to instantiate it or create it or anything,
//we can just start using it

//We reference our document object, then use dot notation to run a function to add an event listener.
//The event we are going to listen for, is 'DOMContentLoaded'.
document.addEventListener('DOMContentLoaded', (event) => {
    //All of our DOM manipulation will be done within this lamba within addEventListener

    //So now, we will start to work with our HTML elements as Javascript variables/objects
    //To select our button (in our HTML) we will use getElementById()
    const changeTextButton = document.getElementById("changeTextButton");

    //Now we will add a listener to that button we selected and stored in changeTextButton above
    changeTextButton.addEventListener('click', () => {

        

    });//Closing the button.addEventListener() method

}); //Closing the document.addEventListener() method