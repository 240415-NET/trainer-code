//So this is my TypeScript file, notice that it ends in a .ts extension
//This file cannot be run as it is by node. We need to call the TypeScript Compiler
//using the tsc <NameOfMyFile>.ts to compile it (essentially translate) into a .js file
//Then you can node <NameOfMyFile>.js to run that generated JavaScript file
//If you intend to work with .ts in your P2, you would generate the .js file and attach 
//that via the script tag in your HTML file's body

//Simple/Variable types - These come in from JS. They are things like string, number, boolean, etc.
//We can use typescript's explicit typing on these variables via the following syntax.
let myBoolean: boolean = true;
let accountBalance: number = 15.67;
let petName: string = "Ziggy";

//Unless disabled in the tsconfig.json file, we can still use implicit/inferred typing in typescript.
//However, the compiler will catch you while you're coding if you try to violate the type of that variable.
let username = "jon123";
//username = 143; - This results in an error because TS is still enforcing it's type system even for variables
//who's type was inferred

//Tuples
//Tuples are useful when you want an array with both a fixed number of elements within it
//and different but defined types for each element
let myFirstTuple: [string, number, boolean];
myFirstTuple = ["This is inside my tuple, at element 0. It HAS to be a string", 23, false];

console.log(myFirstTuple);

//This sum is outside the scope of the addTwoNumbers function
let sum: number = 9;

//Functions
//Functions work similarly to JS, but we can do things like define return and argument types
function addTwoNumbers(x : number, y : number): number {

    let sum : number = 0;

    sum = x + y;

    return sum;
}

console.log(addTwoNumbers(3.67, 113.7));

console.log(sum);

//Arrays
//Arrays in TS are going to work the same as in JS with the added benefit of type safety
//(behaves like a C# list)

let numberList: number[] = [12, 45, 88];
numberList.push(55);

let petNameList: string[] = ['pancake', 'ellie'];

console.log(numberList);
console.log(petNameList);

petNameList.forEach((petName) => {
    console.log(petName)
});

//Enums 
//A special data structure (also in many other languages such as C# and Java) that represent a group of constants
//They can be either string or numeric

enum stringCardinals {
    North = 'north',
    East = 'east',
    South = 'south',
    West = 'west'
}

console.log(stringCardinals.East);

enum numericCardinals {
    North = 1, 
    East = 2,
    South = 4,
    West = 8
}

console.log(numericCardinals.West);

//Type Aliases
//Type aliases are used to create a new name for a user defined type
//Here we say that we have a 'pet' type and it MUST be either 'cat' or 'dog'
//If we try to give a variable of type 'pet' a value of 'gator' it will complain
type pet = 'cat' | 'dog';

let ellie: pet = 'dog';
//let pancake: pet = 'gator'; - Cant do this!

//Here we define a user defined type of type userId, and say that it MUST be a number
type userId = number;

let myUserId: userId = 789798;

//Interfaces 
//Interfaces are used to define the structure of the an object
//They provide a way to ensure that an object adheres to a specific "shape" 
//(this can be leveraged to make sure we get specific types of JSON return for example)
interface User{
    userId: string;
    userName: string;
    age?: number; //We can use the question mark to mark a property in an interface as optional. 
} //It is not that the property will be null, it's that it's not required to be in the objects of this interface at all

let josh : User = {userId: "123-345", userName: 'Josh'};


console.log(josh);

//Classes 
//Classes can provide implementation details like methods and constructors, whereas interfaces are used 
//to define only the structure of the object. Classes form the blueprint for objects and their behaviors, and can
//be instantiated, interfaces cannot.

interface Animal {
    species: string;
}

class Bird implements Animal{
    species: string;
    birdHeight: number;
    birdWeight: number;
    birdColor: string;

    constructor(species: string, height: number, weight: number, color: string){
        this.species = species;
        this.birdHeight = height;
        this.birdWeight = weight;
        this.birdColor = color;
    }

    //Unlike interfaces we can define methods that belong to objects of this class
    birdCall(): string {
        return `I am a ${this.species}`;
    }
}

let yellowWarbler = new Bird('yellow warbler', 5, .36, 'yellow');

console.log(yellowWarbler.birdCall());

class Dunlin extends Bird {

    constructor(species: string, height: number, weight: number, color: string){
        super(species, height, weight, color); // Calling the constructor inherited from Bird
    }

    dunlinActivities(): string {
        return '*Things that dunlins like to do!*'
    }
}

//Now if we create a new Dunlin object, it has access to all the methods and fields from both bird and Dunlin,
//and it inherits the implementation of the Animal interface implemented in Bird

let myDunlin = new Dunlin('Dunlin', 7, 3, 'grey');

console.log(myDunlin.birdCall());
console.log(myDunlin.dunlinActivities());