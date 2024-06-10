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
//They are last in - first out with things like push (add an element to the end), and pop (remove the last element)

let numbers = [2, 5, 7, 10 , 1];

//This method sorts an array... alphabetically. 
numbers.sort();

console.log(numbers);

//I can also add to arrays and remove items from arrays dynamically
numbers.push(33); // adding a new item to my array
numbers.pop();

//Dates - dates in javascript are *TECHNICALLY* represented under the hood by an integer
//This integer denotes the time IN MILLISECONDS that has passed since the beginning of the UNIX epoch
//So, it's the time in milliseconds since Jan 1st 1970 UTC time. 

let firstDate = new Date("2004");
console.log(firstDate);

//Maps - equivalent to a C# dictionary stores things in key value pairs
//We can use the .get() function to lookup via a key
let myMap = new Map();
myMap.set("2", "ellie");
myMap.set(2, "the value of 2");

console.log(myMap.get("2"));

//Sets - collection of unique values (cannot have duplicates)
let mySet = new Set([1, 3,5, 6]);
console.log(mySet);

mySet.add(1);
console.log(mySet);

//Note - In Javascript, functions themselves are first-class objects like all the others above.
//That means, we can do some weirder stuff. We can assign a function to a variable, we can pass
//functions as arguments to other functions, and we can even return a function as the result of a function

//We do have a way to check type in Javascript, similar to C#
//using "typeof"

console.log(typeof 5);
console.log(typeof 'hello');
console.log(typeof true);
console.log(typeof firstDate);
