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