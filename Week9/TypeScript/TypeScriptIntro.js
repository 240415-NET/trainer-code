//So this is my TypeScript file, notice that it ends in a .ts extension
//This file cannot be run as it is by node. We need to call the TypeScript Compiler
//using the tsc <NameOfMyFile>.ts to compile it (essentially translate) into a .js file
//Then you can node <NameOfMyFile>.js to run that generated JavaScript file
//If you intend to work with .ts in your P2, you would generate the .js file and attach 
//that via the script tag in your HTML file's body
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//Simple/Variable types - These come in from JS. They are things like string, number, boolean, etc.
//We can use typescript's explicit typing on these variables via the following syntax.
var myBoolean = true;
var accountBalance = 15.67;
var petName = "Ziggy";
//Unless disabled in the tsconfig.json file, we can still use implicit/inferred typing in typescript.
//However, the compiler will catch you while you're coding if you try to violate the type of that variable.
var username = "jon123";
//username = 143; - This results in an error because TS is still enforcing it's type system even for variables
//who's type was inferred
//Tuples
//Tuples are useful when you want an array with both a fixed number of elements within it
//and different but defined types for each element
var myFirstTuple;
myFirstTuple = ["This is inside my tuple, at element 0. It HAS to be a string", 23, false];
console.log(myFirstTuple);
//This sum is outside the scope of the addTwoNumbers function
var sum = 9;
//Functions
//Functions work similarly to JS, but we can do things like define return and argument types
function addTwoNumbers(x, y) {
    var sum = 0;
    sum = x + y;
    return sum;
}
console.log(addTwoNumbers(3.67, 113.7));
console.log(sum);
//Arrays
//Arrays in TS are going to work the same as in JS with the added benefit of type safety
//(behaves like a C# list)
var numberList = [12, 45, 88];
numberList.push(55);
var petNameList = ['pancake', 'ellie'];
console.log(numberList);
console.log(petNameList);
petNameList.forEach(function (petName) {
    console.log(petName);
});
//Enums 
//A special data structure (also in many other languages such as C# and Java) that represent a group of constants
//They can be either string or numeric
var stringCardinals;
(function (stringCardinals) {
    stringCardinals["North"] = "north";
    stringCardinals["East"] = "east";
    stringCardinals["South"] = "south";
    stringCardinals["West"] = "west";
})(stringCardinals || (stringCardinals = {}));
console.log(stringCardinals.East);
var numericCardinals;
(function (numericCardinals) {
    numericCardinals[numericCardinals["North"] = 1] = "North";
    numericCardinals[numericCardinals["East"] = 2] = "East";
    numericCardinals[numericCardinals["South"] = 4] = "South";
    numericCardinals[numericCardinals["West"] = 8] = "West";
})(numericCardinals || (numericCardinals = {}));
console.log(numericCardinals.West);
var ellie = 'dog';
var myUserId = 789798;
var josh = { userId: "123-345", userName: 'Josh' };
console.log(josh);
var Bird = /** @class */ (function () {
    function Bird(species, height, weight, color) {
        this.species = species;
        this.birdHeight = height;
        this.birdWeight = weight;
        this.birdColor = color;
    }
    //Unlike interfaces we can define methods that belong to objects of this class
    Bird.prototype.birdCall = function () {
        return "I am a ".concat(this.species);
    };
    return Bird;
}());
var yellowWarbler = new Bird('yellow warbler', 5, .36, 'yellow');
console.log(yellowWarbler.birdCall());
var Dunlin = /** @class */ (function (_super) {
    __extends(Dunlin, _super);
    function Dunlin(species, height, weight, color) {
        return _super.call(this, species, height, weight, color) || this; // Calling the constructor inherited from Bird
    }
    Dunlin.prototype.dunlinActivities = function () {
        return '*Things that dunlins like to do!*';
    };
    return Dunlin;
}(Bird));
//Now if we create a new Dunlin object, it has access to all the methods and fields from both bird and Dunlin,
//and it inherits the implementation of the Animal interface implemented in Bird
var myDunlin = new Dunlin('Dunlin', 7, 3, 'grey');
console.log(myDunlin.birdCall());
console.log(myDunlin.dunlinActivities());
