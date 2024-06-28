# JavaScript Review

* JavaScript Fundamentals
    - JavaScript Introduction
        - Functional programming language: functions can be passed around as arguments, returned from functions, assigned to variables
            - Allows us to utilize "functional programming" as a paradigm
        - Object-oriented: utilize objects that contain properties and behaviors (methods)
        - Single-threaded: JS uses a single-threaded approach that can still be non-blocking via asynchronous operations. Usually, callback functions play a big role in asynchronous programming
        - Cross-platform: Originally, JS was designed to run in web browsers, but with Node.js, we can finally develop JS apps outside of the web browser. Node.js is what brought along the world of server-sided JS.
        - Dynamic and weakly typed
            - Dynamic means the type of variable can change
            - Weakly means we don't need to specify the type of a variable
    - Naming conventions
        - Constants should generally be named with UPPER_CASE_LIKE_THIS
        - Variables should be named using camelCase
        - Functions should be named using camelCase
        - Classes and function constructors should be named using PascalCase
    - Datatypes
        - string
            - Types of string literals
                - `'string'`
                - `"string"`
                - template literals (``), ${} <- evaluating expressions inside the template literal
        - number
        - boolean
        - undefined
        - null
        - object
    - Assignment Operators
        - `=`
        - `+=`
        - `-=`
        - `*=`
        - `/=`
        - `%=`
        - `**=`
    - Arithmetic Operators
        - `+`
        - `-`
        - `*`
        - `/`
        - `%`
        - `**`
        - These operators follow PEMDAS
            - Parentheses first
            - Exponentials second
            - Multiplication and division third
            - Addition and subtraction fourth
    - Comparison Operators
        - `==`
        - `===`
        - `!=`
        - `!==`
        - `>`
        - `>=`
        - `<`
        - `<=`
    - Logical Operators
        - `&&`: and
        - `||`: or
        - `!`: not
    - Type Coercion
        - Automatic conversion from one type to another
        - '5' == 5
        - +'5'
        - if (10) { }
        - '5' + 3 -> '53'
        - Truthy/Falsy Values
            - Everything is Truthy except...
                - 0 (Falsy)
                - undefined (Falsy)
                - null (Falsy)
                - '' (Falsy)
                - NaN (Falsy)
            - Make sure you understand the concept of truthy and falsy, especially whenever you check if a variable is undefined or null, for example
            - You don't need to explicitly write out a check for null or undefined
    - Functions
        - Functions are blocks of code that can be re-used and called over and over to perform some task
        - We can pass arguments into functions, which have variables that can be defined known as parameters that map to those arguments
        - We can also return values from a function, so that when the function completes, we can output data from that function
        - Types of functions
            - named functions
                - `function someFunction() {}`
            - anonymous functions
                - `function() {}`
            - arrow functions
                - `() => {}`
                - Arrow functions are a little bit different than named functions or anonymous functions in that they inherit the this keyword from the surrounding scope in which the arrow function was defined. Named functions and anonymous functions, on the other hand, receive their this keyword from the object in which the function was invoked
        - Default parameters
            - We can define default values for parameters in a function so that if an argument is not passed in for that parameter, the parameter will take the default value
            - `function myFunction(x = 10, y = 20) { }`
    - Variable Scopes
        - Refer to the availability of a variable to be accessed
        - 3 different types of scopes
            - Global scope
                - A variable has been declared outside of any function or block of code
                - `var`, `let`, `const`
                - Any functions or blocks of code can access global scoped variables, as well as code directly in the global scope
            - Function scope
                - A variable declared within a function
                - `var`, `let`, `const`
                - Any blocks of code within that function can access the function scoped variable, as well as code directly in the function scope
            - Block scope
                - A variable declared within a block of code (except var, because var does not support block scope)
                - `let` and `const`
                - Code within that block can access the block scoped variable
        - Var v. Let v. Const
            - Var can only support global scope and function scope
                - If you declare a var variable inside of a block, it CANNOT be block scoped
            - Let and const can both support block scope (as well as global and function scope)
                - The different between const and let is that let can be re-assigned new values, while const cannot be re-assigned
                - Both let and const were introduced in ES6 (ECMAScript 6 aka ECMAScript 2015)
    - Arrays
        - Arrays in JS are dynamic in size
        - Items in an array are indexed
            - Starts at 0
            - Goes up to array.length - 1
        - Common methods
            - `.push(element)`: add to end
            - `.unshift(element)`: add to beginning
            - `.pop()`: removes element from end and returns removed element
            - `.shift()`: removes element from beginning and returns removed element
    - Control flow
        - If - else if - else
            - If: Used to execute code if a condition is met
            - Else-if: used for the same purpose if the if condition wasn't met
                - We can use multiple else-ifs so that it will keep going down the else-if chain until there's something true
            - Else: used as a last resort to execute some code if everything was false
            - Configurations
                - We can do if by itself
                - We can do if - else
                - We can do if - else if
                - We can do if - else if - else if
                - We can do if- else if - else if - else if - else
                - etc...
        - Switch
            - Switch is used to execute a "case" of code if the case matches the value of some variable
                - `switch(someVariable) { case "someValue": ... break; }
                - Use a `break` keyword at the end of each case to prevent "fall-through" of execution to subsequent cases
        - Loops
            - For loop
                - `for (initialization; condition; increment/decrement) {}`
                - `for (let i = 0; i < 100; i++) {}`
                - `for (let i = arr.length - 1; i >= 0; i--) {}`
            - While loop
                - `while (condition) {}`
                - While some condition is true, the while loop will run
            - Do - while loop
                - `do { } while (condition);`
                - Do-while loop will ALWAYS execute at least once, because the condition is evaluated at the end
            - Other keywords
                - `break`: this will break out of the loop
                - `continue`: end the current iteration through the loop and continue onto the next iteration
    - Objects
        - Collections of key-value pairs
            - Each key-value pair is referred to as a "property"
        - Objects provide a way to "encapsulate" data and behaviors into a single unit
        - We can access individual values using
            - dot notation
                - `myObj.age`
            - square bracket notation
                - `myObj['age']`
        - We can also create new properties even after an object has already been created
            - `myObj.newProperty = 'my new property'`
        - An object can also have properties which are also objects
            - `myObj.property1 = { prop1: 20, prop2: 35 }`
        - An object can have properties that are functions
            - `myObj.someFunc = function() {}`
        - Ways to create objects
            - Object literals (`{}`)
                - `{ name: 'Bach', age: 25, favoriteColor: 'blue' }`
            - Function constructors
                - `new` keyword to create object from function constructor
                ```javascript
                function Person(name, age, favoriteColor) { 
                    this.name = name; 
                    this.age = age; 
                    this.favoriteColor = favoriteColor; 
                }

                Person.prototype.greet = function() {
                    // ...
                }
                ```
            - Classes
                - `new` keyword to create object from class
                ```javascript
                class Person { 
                    constructor(name, age, favoriteColor) { 
                        this.name = name; 
                        this.age = age; 
                        this.favoriteColor = favoriteColor; 
                    }
                    
                    function greet() {
                        // ...
                    }
                }
                ```
    - JSON
        - Stands for JavaScript Object Notation
        - Data interchange format that is language agnostic. As long as a programming language has a library for parsing JSON, then we can utilize JSON with that language
        - Normally, JSON is used to transmit data over the internet via the HTTP protocol
        - JSON v. JS objects
            - keys in JSON must be surrounded by double quotes ""
        - JSON.stringify() and JSON.parse
            - JSON.stringify(obj): used to convert an object in JS into a JSON string
            - JSON.parse(jsonString): used to convert a JSON string into a JS object


* JavaScript Advanced
    - Spread / Rest Operator
        - The spread operator `(...)` allows for elements of an array or properties of an object to be spread out into a new array or object.
        - The spread operator can be used to copy arrays and objects, or to concatenate arrays.
        - ```javascript
            // Copying an array
            let originalArray = [1, 2, 3];
            let copiedArray = [...originalArray];
            console.log(copiedArray); // [1, 2, 3]

            // Concatenating arrays
            let array1 = [1, 2, 3];
            let array2 = [4, 5, 6];
            let concatenatedArray = [...array1, ...array2];
            console.log(concatenatedArray); // [1, 2, 3, 4, 5, 6]

            // Spreading elements of an array as function arguments
            function add(a, b, c) {
                return a + b + c;
            }
            let numbers = [1, 2, 3];
            console.log(add(...numbers)); // 6
        - The rest operator `(...)` allows for multiple individual elements to be collected into an array.
        - The rest operator can be used in function arguments to gather all remaining parameters into an array.
        - ```javascript
            // Gathering all remaining function arguments into an array
            function logArguments(firstArg, ...restOfArgs) {
                console.log(firstArg);
                console.log(restOfArgs);
            }
            logArguments(1, 2, 3, 4, 5);
            // Output:
            // 1
            // [2, 3, 4, 5]

            // Destructuring an array
            let numbers = [1, 2, 3, 4, 5];
            let [first, ...rest] = numbers;
            console.log(first); // 1
            console.log(rest); // [2, 3, 4, 5]
    - Guard Operator
        - The guard operator `(?.)` is a shorthand for checking the existence of a property or object before accessing or using it.
        - The guard operator returns undefined instead of throwing an error when attempting to access a property of null or undefined.
        - ```javascript
            let person = {
                name: "John",
                address: {
                    street: "123 Main St",
                    city: "San Francisco"
                }
            };

            // Using the guard operator
            let street = person?.address?.street;
            console.log(street); // "123 Main St"

            // Without the guard operator
            let city;
            if (person && person.address) {
                city = person.address.city;
            }
            console.log(city); // "San Francisco"
    - Errors
        - Errors are exceptional conditions that occur in a program during its execution.
        - There are different types of errors in JavaScript, including `SyntaxError`, `TypeError`, `RangeError`, and `ReferenceError`.
        - Error handling can be done using try-catch blocks, where code is placed in a try block and exceptions are caught in a catch block.
        - Custom error types can be created using the Error constructor and extending the Error prototype to add additional information.
        - ```javascript
            // Throwing a custom error
            function divide(a, b) {
                if (b === 0) {
                    throw new Error("Cannot divide by zero");
                }
                    return a / b;
            }

            // Catching errors with a try-catch block
            try {
                let result = divide(10, 0);
                console.log(result);
            } catch (error) {
                console.error(error.message); // "Cannot divide by zero"
            }
    - Timing Events
        - Timing events refer to events that are scheduled to occur at a specific time or after a specific interval of time.
        - Common timing events in JavaScript include setTimeout, setInterval, and requestAnimationFrame.
        - setTimeout schedules a function to run after a specified amount of time. It returns a unique ID that can be used to cancel the scheduled event with clearTimeout.
    - Promises
        - They are objects in JavaScript that represent the eventual outcome of an asynchronous operation.
        - They have three states: pending, fulfilled, and rejected.
        - They can be created using the Promise constructor, which takes a function as its argument. The function should have two parameters, resolve and reject, which are used to resolve or reject the promise, respectively.
        - Promises have a then method that can be used to specify what should happen when the promise is fulfilled or rejected. The then method takes two functions as arguments, one for fulfillment and one for rejection.
        - They also have a catch method that can be used to specify what should happen when the promise is rejected. The catch method takes a function as its argument, which should handle the rejection.
        - ```javascript
            // Creating a promise
            const promise = new Promise(function(resolve, reject) {
                setTimeout(function() {
                        resolve("Resolved");
                    }, 1000);
            });
            // Using the then and catch methods
            promise
                .then(function(value) {
                    console.log(value);
                })
                .catch(function(error) {
                    console.error(error);
                });
            // Output:
            // Resolved
    - Async Await
        - `async/await` allows you to write asynchronous code that looks and behaves like synchronous code.
        - The `async` keyword is used to declare an asynchronous function, which returns a Promise by default.
        - The `await` keyword can be used within an asynchronous function to pause execution until a Promise is resolved.
        - ```javascript
            // Asynchronous function
            async function fetchData() {
            const response = await fetch("https://jsonplaceholder.typicode.com/posts");
            const data = await response.json();
            console.log(data);
            }

            // Calling the asynchronous function
            fetchData();