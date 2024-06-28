# TypeScript Review

* Node.js
    - JavaScript runtime primarily used for running server-sided applications
    - Commes with a built-in extensive number of modules, such as the `fs` module for dealing with files, `http` module for creating an HTTP server, etc.
    - Comes with npm (Node Package Manager), which is the standard way for creating a Node project and installing third-party libraries that we can utilize while developing an application
        - Important files/directories for node projects
            - `package.json` file: it is the master file for a node project. It contains a list of scripts that can be ran, a list of the names of dependencies that the project needs, and also the devDependencies that used during development
            - `package-lock.json` file: it is the file that contains the exact versions of all dependencies that are required. This includes not only the dependencies that we directly installed, but also the dependencies of those dependencies. This is an important file as well, because it allows for other developers that we share the project with to be able to install the exact same versions on their machines
            - `node_modules` folder: contains all of the dependencies that need to be installed for the project to run properly. This folder can be a huge folder, so it is recommended to NOT include this folder in the Git repository, as it can make the repository extremely bloated in terms of space. Therefore, the node_modules folder should be ignored inside of the `.gitignore` file
        - Npm Commands
            - `npm init`: used to help us initialize a new node project (and creates the package.json file for us)
            - `npm install`: This will go and install all required dependencies by scanning the package.json and/or the package-lock.json file. So, when another developer needs to have the dependencies, they just need to run this command (or if you delete the node_modules folder, you can get it back this way)
            - `npm install <dependency name>`: Allows us to install a new dependency and include it into our package.json and package-lock.json files
            - `npm install <dependency name> --save-dev`: Allows us to install a new developer dependency (a dependency that is only required during development and is not required for the actual application to run)
            - `npm uninstall <dependency name>`: uninstall a dependency that is no longer needed
* TypeScript
    - Overview
        - TypeScript is a statically typed, superset of JavaScript
        - It adds optional type annotations to JavaScript, which allows for type checking at compile time
        - This can catch type-related errors early in the development process and improve overall code quality
        - TypeScript is fully compatible with existing JavaScript code and can be gradually introduced into existing projects
    - JavaScript vs TypeScript
        - JavaScript:
            - Is a dynamically typed language
            - Types are determined at runtime, not at compile time
            - Does not have strict type checking
            - Often requires more runtime error checking
        - TypeScript:
            - Is a statically typed, superset of JavaScript
            - Adds optional type annotations to JavaScript, which allows for type checking at compile time
            - Is more suited for large and complex applications, as it can catch type-related errors early in the development process
            - Requires a build step to transpile TypeScript code into JavaScript before it can run in a browser or on a server
    - TypeScript Compiler
        - The TypeScript compiler (tsc) is the tool that transpiles TypeScript code into JavaScript
        - The compiler can be configured using a tsconfig.json file, which allows customization of the transpilation process
        - The compiler can perform type checking and report errors if any type annotations are not satisfied
        - `tsc name_of_file.ts`: this command will generate a javascript file from the typescript file provided
    - Simple Types
        - Simple types in TypeScript include primitive types such as number, string, boolean, undefined, and null
        - These types are used to represent values in the most basic and straightforward way
        - When declaring variables or function parameters with simple types, the type can be explicitly declared (e.g. `let name: string`) or implicitly inferred from the value assigned to the variable (e.g. `let name = 'John'`).
        - ```typescript
            let name: string = "John";
            let age: number = 30;
            let isEmployed: boolean = true;

            function getFullName(firstName: string, lastName: string): string {
              return firstName + " " + lastName;
            }

            let fullName: string = getFullName("Jane", "Doe");
    - Object Types
        - Object types in TypeScript allow the representation of more complex data structures, such as records or dictionaries
        - Object types can be declared using object type literals (e.g. `{ name: string; age: number; }`) or interface types
        - Object type literals are used to declare inline object types, while interface types are named types that can be used across multiple parts of the code
        - Object types can include properties with types (e.g. `name: string`), as well as methods (e.g. `greet(): void`)
        - ```typescript
            interface Person {
            name: string;
            age: number;
            greet(): void;
            }

            let person: Person = {
            name: "John",
            age: 30,
            greet() {
                console.log(`Hello, I am ${this.name}.`);
            }
            };

            person.greet();
    - Union Types
        - Union types are declared using the | operator (e.g. string | number)
        - When using union types, the variable must match at least one of the types in the union
        - Union types are useful for representing values that can be of different types, such as function parameters that accept either a string or a number
        - ```typescript
            function getLength(value: string | number): number {
              if (typeof value === "string") {
                return value.length;
              } else {
                return value.toString().length;
              }
            }
    - String Enums
        - String enums in TypeScript are a way to define a set of named string constants
        - String enums are declared using the enum keyword followed by a unique name
            - `enum Color { Red = "RED", Green = "GREEN", Blue = "BLUE" }`
        - The values of string enums are string literals, and can be assigned explicitly using the = operator
            - `Red = "RED"`
        - ```typescript
            enum Color { Red = "RED", Green = "GREEN", Blue = "BLUE" }

            let color: Color = Color.Red;
            console.log(color); // Red

            let colorName: string = Color[color];
            console.log(colorName); // RED

            color = Color["GREEN"];
            console.log(color); // Green
    - Numeric Enums
        - Numeric enums in TypeScript are a way to define a set of named numeric constants
        - Numeric enums are declared using the enum keyword followed by a unique name 
            - `enum Direction { Up, Down, Left, Right }`
        - The values of numeric enums are numbers, and can be assigned explicitly using the = operator 
            - `Up = 1, Down = 2, Left = 3, Right = 4`
        - or by default starting from 0
            - `Up = 0, Down = 1, Left = 2, Right = 3`
        - Numeric enums can be used to represent named values that are numeric-based, such as error codes, or to avoid the use of hardcoded numeric values throughout the code
        - ```typescript
            enum Direction { Up, Down, Left, Right }

            let directionValue: number = direction;
            console.log(directionValue); // 0

            let directionName: string = Direction[directionValue];
            console.log(directionName); // Up
    - Classes
        - Classes in TypeScript are a way to define reusable objects that can have properties and methods
        - Classes are declared using the class keyword followed by a unique name (e.g. class Person {...})
        - Classes can have properties, which define the state of an object (e.g. name: string), and methods, which define the behavior of an object (e.g. greet() {...})
        - Properties and methods can be private, protected, or public, and their visibility is controlled using the private, protected, or no keyword, respectively
        - ```typescript
            class Person {
                name: string;
                age: number;

                constructor(name: string, age: number) {
                    this.name = name;
                    this.age = age;
                }

                greet() {
                    console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
                }
            }

            let person = new Person("John Doe", 30);
            person.greet(); // Hello, my name is John Doe and I am 30 years old.
    - Functions
        - They are declared using the function keyword followed by a name and a set of parameters (e.g. function greet(name: string) {...})
        - They can have a return type specified using a colon (e.g. function greet(name: string): void {...}), which defines the type of value that the function returns
        - They can be anonymous, and can be assigned to variables (e.g. let greet = function(name: string) {...})
        - Functions can be used as values, and can be passed as arguments to other functions, or returned as values from other functions
        - Functions can be overloaded, which means that they can have multiple signatures that are used based on the types of the arguments passed
        - ```typescript
            function greet(name: string): void {
              console.log(`Hello, ${name}`);
            }

            greet("John Doe"); // Hello, John Doe
    - Array Generics
        - Array generics are a way to create arrays with a specific type in TypeScript
        - Array generics are declared using square brackets and the type parameter (e.g. let numbers: Array<number> = [1, 2, 3];)
        - The type parameter defines the type of the elements that can be stored in the array
        - Array generics can be used with any type, including custom types defined using classes or interfaces
        - ```typescript
            let numbers: Array<number> = [1, 2, 3];
    - Basic Generics
        - Generics are a way to create reusable code that can work with multiple types
        - Generics are declared using angle brackets and a type parameter (e.g. function identity<T>(arg: T): T {...})
        - The type parameter can be any valid TypeScript type, including custom types defined using classes or interfaces
        - Generics are useful for creating functions, classes, and interfaces that can work with multiple types
        - The type parameter is automatically inferred from the type of the arguments passed to the function or constructor
        - ```typescript
            function returner<T>(arg: T): T {
                return arg;
            }

            let stringOutput = returner<string>("Hello, World");
            let numberOutput = returner<number>(19);
