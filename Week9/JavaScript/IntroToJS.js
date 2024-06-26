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


//Type coercion in Javascript

//Strings - when a non-string is added to a string, Javascript converts the non-string into a string
//and concats the value
let example = "5" + 5;
console.log(example);
console.log(typeof example);

//Numbers - when a string or boolean is used in a math operation (except using +), JS converts it to a number
//For booleans, true will convert to 1 and false to 0

let result = '5' - 3;
console.log(result);
console.log(typeof result);

let result2 = 1 + true; // Since true evaluates to the number 1, this resolves to 2
console.log(result2);

//Boolean coercion - everything in JS is either "truthy" or "falsy"
//Truthy - literally everything that is note "falsy"
//Falsy - false, 0, -0, 0n, "" (empty string), null, undefined, Nan.

if('') {
    console.log("This will not run, because empty strings are falsy");
}

if(27) {
    console.log("This should run, as any number besides 0 and -0 is truthy");
}

if(mySet) {
    console.log("Again, this should run as it's not a in the list of falsy values");
}


//Functions in javascript
//Functions in javascript allow us to re-use code, the same way as C#
//Functions declared as part of an object are referred to as methods
//There are a few different ways to create functions in Javascript

//Function declarations - using the keyword function
function Greet(name) {
    console.log(`Hello ${name}!`);
};

Greet("Yenny");

//Function expressions - defining a function as part of an expression 
//(looks similar to variable declaration)
const AddTwoNumbers = function (x, y) {
    return x + y;
};

let sum = AddTwoNumbers(5, 8.89);
console.log(sum);

//We can declare a function using arrow syntax as a shorthand. This is really popular,
//and you will probably encounter it in existing codebases that you go on to work within

const NewGreet = (newName) => {
    console.log(`Hello ${newName}, welcome from my arrow greeting function!`);
};

NewGreet("Fernando");

//Classes in JS

//Constructor functions/methods
//we declare our class using the class keyword, it serves as a template for objects
//...same as C#

//Create a vehicle class, that is then called to create a vehilce object in my person
class Vehicle {

    //Unlike C#, we set the properties of our class within the constructor itself
    //We do not do things like declaring properties to hold those values
    //I.e. 
    //No let make;
    //No let model;
    //We just take them as arguments for our constructor method, and then set them
    //using this.propertyName = argumentFromConstructor
    constructor (make, model)
    {
        this.make = make;
        this.model = model;
    }
}

class DefaultPerson {
    //Lets create a constructor method! - In JS we only get one constructor 
    //and if you don't create one you get the default no-arg constructor
    constructor (personName, hobby, make, model) {
        this.personName = personName;
        this.hobby = hobby;
        this.vehicle = new Vehicle(make, model);
    }
    AboutMe() { // We can also store functions inside of classes, like in C#
        //A function that belongs to a class is referred to as a method 
        console.log(`My name is ${this.personName}, my vehicle is a 
            ${this.vehicle.make} ${this.vehicle.model}`);
    }
};

let josh = new DefaultPerson("Josh", "volleyball", "Ford", "1972 Pinto");

console.log(josh);

//Inhertiance in JS - instead of the C# colon notation, we use the "extends" keyword
class Employee extends DefaultPerson {
    //When I create a constructor for Employee, I will call the parent class constructor
    //using super()
    constructor (personName, hobby, make, model, jobTitle) {
        //This is how we use super() to call the parent class constructor
        super(personName, hobby, make, model);
        //We must call the super() (parent class constructor) before setting any new properties
        //in the child with the normal this.property syntax
        this.jobTitle = jobTitle;
    }
    //Lets say I want to override and provide a new implementation of AboutMe() in my employee class
    AboutMe() {
        console.log(`My name is ${this.personName}, my job is ${this.jobTitle}`);
    }
}

let marcus = new Employee("marcus", "sleeping", "reliant", "robin", "Trust fund baby");

console.log(marcus);
josh.AboutMe(); //josh is a default person object
marcus.AboutMe(); //marcus is an employee object