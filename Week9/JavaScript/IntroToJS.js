//This is a JS comment, we can see it's the familiar double slash that we 
//are used to

//Javascript will run sequentially from top to bottom of the file.
//You can notice that we will not be using any sort of Main method equivalent. 

//Variable declaration

//Let is used for variables that we want to be capable of being reassigned. 
//It is block scoped, so if I declare using let inside of a function it can only be seen within
//the scope of that function

let name = "pancake";

//Const is used for "constants" i.e. variables that we do not want to change during run time.
//It is also block scoped, the same way that let is
const age = 17;

//There is a forbidden third way to declare variables in JS, called "var"
//Variables declared using var are globally scoped AND mutable.
//This can cause many many issues.

var dontDoThis = "seriously please don't";

//Data-types 
// JS has some built in primitive types, here is an example of a few of them that 
//will come up most often.

//numbers - used to represent both integers and floating point numbers
let myNumber = 11.5;

//strings
//represents a series of characters - we can use single quotes, double quotes
//OR backticks (backticks are used for string literals or template strings)

let dogName = "Ellie"; dogName = 20;
let steveName = 'Steve says "hello!"';

//String literal example 
let message = `${dogName} is due for a vet appointment!`;

//String literals are useful for multi-line blocks of text
let longMessage = `Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
    Cras finibus, tortor ut faucibus fringilla, eros augue iaculis nibh, 
    sit amet aliquam velit neque a arcu. Vestibulum convallis ultrices pulvinar. 
    Aenean non augue pharetra, congue ante non, fringilla urna. Aliquam massa 
    dolor, malesuada eu nunc non, condimentum commodo felis. Vestibulum pulvinar 
    enim eu odio tincidunt, a egestas quam consectetur. Duis lobortis malesuada 
    commodo. Pellentesque sollicitudin viverra lorem id luctus. Duis maximus orci 
    justo, ac congue metus semper vel. Curabitur id pellentesque eros.`

console.log(message);

//We will be using these string literals liberally to store things like dynamic HTML updating
let htmlToUpdate = `<li>something to update</li>
                    <li>something else to update</li>`

//Beyond strings we have booleans - they hold a true or false
let flag = true;

//In javascript we do have a delineation between things that are undefined and things that are null

//Undefined - represents an uninitialized variable
let corey; // this would be undefined
console.log(corey);

//Null - represents the INTENTIONAL absence of any value
let ross = null;
console.log(ross);


//Object data types

//Objects - strangely resembles json.....
let person = {
    name : "Ron",
    hobby : "Birding",
    vehicle : { // Our objects can have other objects nested inside of them 
        make: "Morgan",
        model : "3-Wheeler thing"
    }
};

//We can access the properties of an object using dot notation just like c#
console.log(person.name);
console.log(person.vehicle.model);

//Arrays - Arrays in JS behave like lists in C#. They are dynamic and have their own built in
//functions. We can also access specific indexs using the myArray[3] syntax

let numbers = [2, 5, 7, 10 , 1];

numbers.sort();

console.log(numbers);