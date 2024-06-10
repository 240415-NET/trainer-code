
## Intro to JS

### C# vs. JavaScript - Differences between C# and JS

C# and JavaScript are both powerful programming languages used in different contexts and for different purposes. Below are key comparisons and contrasts between the two:

#### 1. Type System

- **C#**: Strongly typed language with static typing. This means that type checking is done at compile time, and variables must be declared with a type.
- **JavaScript**: Weakly typed language with dynamic typing. Variables can hold any type of data and their type can change at runtime.

#### 2. Execution Environment

- **C#**: Runs on the .NET framework, primarily used for backend development. It can also be used for desktop and mobile applications via frameworks like Xamarin.
- **JavaScript**: Originally designed to run in web browsers for front-end development. It can also run on servers via Node.js and in various other environments thanks to its versatility.

#### 3. Use Cases

- **C#**: Commonly used for developing Windows applications, enterprise applications, web applications (using ASP.NET), games (using Unity), and more.
- **JavaScript**: Primarily used for adding interactivity to web pages, developing web applications, and server-side development using Node.js. It is also used in frameworks like React, Angular, and Vue.js for building front-end applications.

#### 4. Object-Oriented Programming (OOP)

- **C#**: Fully object-oriented with strong support for encapsulation, inheritance, and polymorphism. It uses classes and objects.
- **JavaScript**: Prototype-based object-oriented language. It doesn't have traditional classes (though ES6 introduced the `class` syntax, it's syntactic sugar over JavaScript's prototypal inheritance).

#### 5. Compilation

- **C#**: Compiled language. Code is compiled into intermediate language (IL) which is then run on the .NET runtime.
- **JavaScript**: Interpreted language (though modern JavaScript engines like V8 compile JavaScript to machine code at runtime for performance optimization).

#### 6. Libraries and Frameworks

- **C#**: Extensive libraries and frameworks within the .NET ecosystem, including ASP.NET for web development, Entity Framework for ORM, and Xamarin for mobile development.
- **JavaScript**: Rich ecosystem of libraries and frameworks like React, Angular, Vue.js for front-end development, and Express.js for back-end development with Node.js.

#### 7. Community and Support

- **C#**: Backed by Microsoft, with strong community support and extensive documentation. It is widely used in enterprise environments.
- **JavaScript**: Massive community with a plethora of resources, tutorials, and forums. It is the most widely used language on the web.

## JS conventions

- <https://www.w3schools.com/js/js_conventions.asp>

## Let vs Const

### `let`

1. **Reassignable**:
   Variables declared with `let` can be reassigned.

   ```javascript
   let x = 10;
   x = 20; // Valid
   console.log(x); // 20
   ```

2. **Block Scope**:
   `let` is block-scoped, meaning it is only accessible within the block it is defined in.

   ```javascript
   if (true) {
       let y = 30;
       console.log(y); // 30
   }
   // console.log(y); // Error: y is not defined
   ```

3. **Temporal Dead Zone**:
   Variables declared with `let` are in a "temporal dead zone" from the start of the block until the declaration is encountered, which means they cannot be accessed before they are declared.

   ```javascript
   // console.log(z); // Error: Cannot access 'z' before initialization
   let z = 40;
   ```

### `const`

1. **Immutable Binding**:
   Variables declared with `const` cannot be reassigned. However, this does not make the value immutable if the value is an object or array.

   ```javascript
   const a = 50;
   // a = 60; // Error: Assignment to constant variable.

   const obj = { name: 'Alice' };
   obj.name = 'Bob'; // Valid
   console.log(obj.name); // 'Bob'
   ```

2. **Block Scope**:
   `const` is also block-scoped, similar to `let`.

   ```javascript
   if (true) {
       const b = 70;
       console.log(b); // 70
   }
   // console.log(b); // Error: b is not defined
   ```

3. **Temporal Dead Zone**:
   Variables declared with `const` are also subject to the temporal dead zone.

   ```javascript
   // console.log(c); // Error: Cannot access 'c' before initialization
   const c = 80;
   ```

4. **Initialization**:
   `const` variables must be initialized at the time of declaration.

   ```javascript
   // const d; // Error: Missing initializer in const declaration
   const d = 90;
   ```

### Comparison Summary

| Feature                     | `let`                                     | `const`                                   |
|-----------------------------|-------------------------------------------|-------------------------------------------|
| Reassignment                | Yes                                       | No                                        |
| Block Scope                 | Yes                                       | Yes                                       |
| Temporal Dead Zone          | Yes                                       | Yes                                       |
| Must be Initialized         | No                                        | Yes                                       |
| Immutability of Binding     | No                                        | Yes                                       |
| Immutability of Value       | No                                        | No (but binding is immutable)             |

### Examples

#### Using `let`

```javascript
let counter = 0;
if (true) {
    let counter = 1; // This counter is different from the outer counter
    console.log(counter); // 1
}
console.log(counter); // 0
```

#### Using `const`

```javascript
const MAX_SIZE = 100;
const array = [1, 2, 3];

array.push(4); // Valid
console.log(array); // [1, 2, 3, 4]

// MAX_SIZE = 200; // Error: Assignment to constant variable.
```

### Use Cases

- **`let`**: Use `let` when you need a variable whose value might change. It is suitable for loop counters, variables that are reassigned, and scenarios where block-scoping is necessary.
- **`const`**: Use `const` when you need to declare constants or variables that should not be reassigned. It is ideal for configuration values, fixed references, and constants.

## Data Types in JS

### Primitive Data Types

1. **Number**
   - Represents both integer and floating-point numbers.
   - Examples: `42`, `3.14`
   - Special numeric values: `Infinity`, `-Infinity`, and `NaN` (Not-a-Number).

2. **BigInt**
   - Represents integers with arbitrary precision.
   - Useful for large integers beyond the safe integer limit for Numbers.
   - Example: `1234567890123456789012345678901234567890n`

3. **String**
   - Represents a sequence of characters.
   - Can be defined using single quotes (`'`), double quotes (`"`), or backticks (`` ` ``) for template literals.
   - Examples: `'Hello'`, `"World"`, `` `Hello, ${name}!` ``

4. **Boolean**
   - Represents a logical entity with two values: `true` and `false`.
   - Example: `true`, `false`

5. **Undefined**
   - Represents an uninitialized variable.
   - Example: `let x; console.log(x); // undefined`

6. **Null**
   - Represents the intentional absence of any object value.
   - Example: `let y = null;`

### Object Data Types

1. **Object**
   - Represents a collection of properties, where each property is a key-value pair.
   - Examples:

     ```javascript
     let person = {
         name: 'John',
         age: 30
     };
     ```

2. **Array**
   - Represents an ordered collection of elements.
   - Example:

     ```javascript
     let numbers = [1, 2, 3, 4, 5];
     ```

3. **Function**
   - Represents a callable object.
   - Example:

     ```javascript
     function greet() {
         console.log('Hello');
     }
     ```

4. **Date**
   - Represents dates and times.
   - Example:

     ```javascript
     let now = new Date();
     ```

5. **Map**
   - Represents a collection of key-value pairs where keys can be of any type.
   - Example:

     ```javascript
     let map = new Map();
     map.set('key', 'value');
     ```

7. **Set**
   - Represents a collection of unique values.
   - Example:

     ```javascript
     let set = new Set([1, 2, 3, 4, 5]);
     ```

### Special Types

- **Function**
  - In JavaScript, functions are first-class objects, meaning they can be assigned to variables, passed as arguments, and returned from other functions.

### Type Checking

- Use `typeof` to check the type of a variable:

  ```javascript
  typeof 42;            // "number"
  typeof 'Hello';       // "string"
  typeof true;          // "boolean"
  typeof undefined;     // "undefined"
  typeof null;          // "object" (this is a quirk in JavaScript)
  typeof Symbol();      // "symbol"
  typeof {};            // "object"
  typeof [];            // "object"
  typeof function(){};  // "function"
  ```

## Type Coercion

Type coercion in JavaScript is the automatic or implicit conversion of values from one data type to another. This process happens in different contexts, such as when performing operations between different data types, during comparisons, or when using values in certain expressions. JavaScript uses type coercion to handle these situations gracefully, often converting values to the expected types behind the scenes.

### Types of Type Coercion

1. **Implicit Coercion**
2. **Explicit Coercion**

### Implicit Coercion

Implicit coercion happens automatically by JavaScript when it expects a certain type. This can lead to some surprising results and bugs if not properly understood. Here are some common scenarios:

#### 1. **String Coercion**

- When a non-string value is added to a string, JavaScript converts the non-string value to a string.

  ```javascript
  let result = 'The number is ' + 5; // "The number is 5"
  let result2 = '5' + 5;             // "55"
  ```

#### 2. **Number Coercion**

- When a string or boolean is used in a mathematical operation, JavaScript converts it to a number.

  ```javascript
  let result = '5' - 3;  // 2
  let result2 = '5' * 3; // 15
  let result3 = '5' / 1; // 5
  let result4 = '5' + 3; // "53" (string concatenation)
  let result5 = true + 1; // 2 (true is coerced to 1)
  let result6 = false + 1; // 1 (false is coerced to 0)
  ```

#### 3. **Boolean Coercion**

- When a value is used in a boolean context, JavaScript converts it to a boolean. Values considered false are called "falsy", and values considered true are called "truthy".

  ```javascript
  if ('') { // Falsy
    console.log('This will not run');
  }
  if ('Hello') { // Truthy
    console.log('This will run');
  }
  if (0) { // Falsy
    console.log('This will not run');
  }
  if (1) { // Truthy
    console.log('This will run');
  }
  ```

### Explicit Coercion

Explicit coercion is done manually by the programmer using functions or operators to convert a value to a desired type.

#### 1. **String Conversion**

- Using `String()` function:

  ```javascript
  let num = 123;
  let str = String(num); // "123"
  ```

- Using `toString()` method:

  ```javascript
  let num = 123;
  let str = num.toString(); // "123"
  ```

#### 2. **Number Conversion**

- Using `Number()` function:

  ```javascript
  let str = '123';
  let num = Number(str); // 123
  ```

- Using unary `+` operator:

  ```javascript
  let str = '123';
  let num = +str; // 123
  ```

#### 3. **Boolean Conversion**

- Using `Boolean()` function:

  ```javascript
  let str = 'Hello';
  let bool = Boolean(str); // true
  let emptyStr = '';
  let boolEmpty = Boolean(emptyStr); // false
  ```

- Using double negation `!!`:

  ```javascript
  let str = 'Hello';
  let bool = !!str; // true
  let emptyStr = '';
  let boolEmpty = !!emptyStr; // false
  ```

### Examples and Edge Cases

#### Comparison Operations

- `==` (Equality) vs. `===` (Strict Equality):

  ```javascript
  5 == '5';  // true (due to type coercion)
  5 === '5'; // false (no type coercion, different types)
  ```

#### Arithmetic Operations

- Addition with strings:

  ```javascript
  5 + '5'; // "55" (number 5 is coerced to string)
  ```

- Subtraction with strings:

  ```javascript
  '5' - 3; // 2 (string '5' is coerced to number)
  ```

## Arrays

### Creating Arrays

#### 1. **Using Array Literals**

- This is the most common and straightforward way to create an array.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry'];
  ```

#### 2. **Using the Array Constructor**

- You can also create arrays using the `Array` constructor.

  ```javascript
  let fruits = new Array('Apple', 'Banana', 'Cherry');
  ```

### Accessing Array Elements

- Elements in an array can be accessed using their index.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry'];
  console.log(fruits[0]); // 'Apple'
  console.log(fruits[1]); // 'Banana'
  console.log(fruits[2]); // 'Cherry'
  ```

### Modifying Arrays

- **Adding Elements**:
  - Using `push()` to add elements to the end of the array.

    ```javascript
    let fruits = ['Apple', 'Banana'];
    fruits.push('Cherry');
    console.log(fruits); // ['Apple', 'Banana', 'Cherry']
    ```

  - Using `unshift()` to add elements to the beginning of the array.

    ```javascript
    let fruits = ['Apple', 'Banana'];
    fruits.unshift('Cherry');
    console.log(fruits); // ['Cherry', 'Apple', 'Banana']
    ```

- **Removing Elements**:
  - Using `pop()` to remove the last element.

    ```javascript
    let fruits = ['Apple', 'Banana', 'Cherry'];
    let lastFruit = fruits.pop();
    console.log(fruits); // ['Apple', 'Banana']
    console.log(lastFruit); // 'Cherry'
    ```

  - Using `shift()` to remove the first element.

    ```javascript
    let fruits = ['Apple', 'Banana', 'Cherry'];
    let firstFruit = fruits.shift();
    console.log(fruits); // ['Banana', 'Cherry']
    console.log(firstFruit); // 'Apple'
    ```

- **Modifying Specific Elements**:

  ```javascript
  let fruits = ['Apple', 'Banana'];
  fruits[1] = 'Cherry';
  console.log(fruits); // ['Apple', 'Cherry']
  ```

### Array Properties and Methods

#### 1. **Length Property**

- The `length` property returns the number of elements in an array.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry'];
  console.log(fruits.length); // 3
  ```

#### 2. **concat()**

- Combines two or more arrays.

  ```javascript
  let fruits = ['Apple', 'Banana'];
  let vegetables = ['Carrot', 'Lettuce'];
  let combined = fruits.concat(vegetables);
  console.log(combined); // ['Apple', 'Banana', 'Carrot', 'Lettuce']
  ```

#### 3. **slice()**

- Returns a shallow copy of a portion of an array.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry', 'Date'];
  let sliced = fruits.slice(1, 3);
  console.log(sliced); // ['Banana', 'Cherry']
  ```

#### 4. **splice()**

- Adds/removes elements from an array.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry'];
  fruits.splice(1, 1, 'Orange'); // Removes 'Banana' and adds 'Orange'
  console.log(fruits); // ['Apple', 'Orange', 'Cherry']
  ```

#### 5. **indexOf() and lastIndexOf()**

- `indexOf()` returns the first index of the specified element.
- `lastIndexOf()` returns the last index of the specified element.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry', 'Banana'];
  console.log(fruits.indexOf('Banana')); // 1
  console.log(fruits.lastIndexOf('Banana')); // 3
  ```

#### 6. **forEach()**

- Executes a provided function once for each array element.

  ```javascript
  let fruits = ['Apple', 'Banana', 'Cherry'];
  fruits.forEach((fruit) => {
      console.log(fruit);
  });
  // Output:
  // Apple
  // Banana
  // Cherry
  ```

#### 7. **map()**

- Creates a new array with the results of calling a provided function on every element in the array.

  ```javascript
  let numbers = [1, 2, 3];
  let doubled = numbers.map(num => num * 2);
  console.log(doubled); // [2, 4, 6]
  ```

#### 8. **filter()**

- Creates a new array with all elements that pass the test implemented by the provided function.

  ```javascript
  let numbers = [1, 2, 3, 4, 5];
  let even = numbers.filter(num => num % 2 === 0);
  console.log(even); // [2, 4]
  ```

#### 9. **reduce()**

- Executes a reducer function on each element of the array, resulting in a single output value.

  ```javascript
  let numbers = [1, 2, 3, 4, 5];
  let sum = numbers.reduce((acc, num) => acc + num, 0);
  console.log(sum); // 15
  ```

## Functions

### Creating Functions

#### 1. **Function Declaration**

A function declaration defines a named function.

```javascript
function greet(name) {
    console.log(`Hello, ${name}!`);
}
```

- **Hoisting**: Function declarations are hoisted to the top of their scope, meaning they can be called before they are defined in the code.

#### 2. **Function Expression**

A function expression defines a function as part of an expression.

```javascript
const greet = function(name) {
    console.log(`Hello, ${name}!`);
};
```

- **Anonymous vs Named**: Function expressions can be anonymous (as above) or named.
- **Hoisting**: Function expressions are not hoisted, meaning they cannot be called before they are defined.

#### 3. **Arrow Functions**

Arrow functions provide a shorter syntax and lexically bind the `this` value.

```javascript
const greet = (name) => {
    console.log(`Hello, ${name}!`);
};
```

- **Short Syntax**: If the function body contains only a single expression, you can omit the curly braces and the `return` keyword.

  ```javascript
  const greet = name => console.log(`Hello, ${name}!`);
  ```

#### 4. **Constructor Function**

Functions can be used as constructors to create objects.

```javascript
function Person(name, age) {
    this.name = name;
    this.age = age;
}
const person1 = new Person('Alice', 30);
```

- **Prototype**: Constructor functions are typically used with the `new` keyword to create new objects.

### Function Parameters and Arguments

#### 1. **Default Parameters**

You can set default values for parameters.

```javascript
function greet(name = 'Guest') {
    console.log(`Hello, ${name}!`);
}
greet(); // Hello, Guest!
```

#### 2. **Rest Parameters**

The `...` syntax allows you to represent an indefinite number of arguments as an array.

```javascript
function sum(...numbers) {
    return numbers.reduce((acc, num) => acc + num, 0);
}
console.log(sum(1, 2, 3, 4)); // 10
```

### Returning Values

Functions can return values using the `return` statement.

```javascript
function add(a, b) {
    return a + b;
}
let result = add(2, 3); // 5
```

### Function Scope

#### 1. **Local Scope**

Variables declared within a function are local to that function.

```javascript
function greet() {
    let message = 'Hello!';
    console.log(message);
}
greet();
// console.log(message); // Error: message is not defined
```

#### 2. **Global Scope**

Variables declared outside of functions are global and can be accessed from any function.

```javascript
let message = 'Hello, world!';
function greet() {
    console.log(message);
}
greet(); // Hello, world!
```

### Higher-Order Functions

Functions that take other functions as arguments or return functions as their result are called higher-order functions.

```javascript
function higherOrderFunction(callback) {
    callback();
}

function sayHello() {
    console.log('Hello!');
}

higherOrderFunction(sayHello); // Hello!
```

### Functions that are properties of objects are called methods

```javascript
const obj = {
    greet: function(name) {
        console.log(`Hello, ${name}!`);
    }
};
obj.greet('Alice'); // Hello, Alice!
```

## Arrow Functions

Arrow functions in JavaScript are a concise way to write function expressions. Introduced in ECMAScript 6 (ES6), arrow functions have a simpler syntax and lexically bind the `this` value from the surrounding code. They do not have their own `this`, `arguments`, `super`, or `new.target` bindings.

### Basic Syntax

The basic syntax of an arrow function is:

```javascript
(param1, param2, ..., paramN) => { /* function body */ }
```

#### Examples

1. **Basic Arrow Function**

```javascript
const add = (a, b) => {
    return a + b;
};
console.log(add(2, 3)); // 5
```

2. **Implicit Return**
If the function body consists of a single expression, you can omit the curly braces and the `return` keyword. The value of the expression will be returned automatically.

```javascript
const add = (a, b) => a + b;
console.log(add(2, 3)); // 5
```

3. **No Parameters**
For functions with no parameters, use an empty set of parentheses.

```javascript
const greet = () => console.log('Hello!');
greet(); // 'Hello!'
```

4. **Single Parameter**
For functions with a single parameter, the parentheses around the parameter list are optional.

```javascript
const greet = name => console.log(`Hello, ${name}!`);
greet('Alice'); // 'Hello, Alice!'
```

### Practical Uses

1. **Array Methods**
Arrow functions are commonly used with array methods like `map`, `filter`, and `reduce`.

```javascript
const numbers = [1, 2, 3, 4, 5];

// Double each number
const doubled = numbers.map(num => num * 2);
console.log(doubled); // [2, 4, 6, 8, 10]

// Filter even numbers
const evens = numbers.filter(num => num % 2 === 0);
console.log(evens); // [2, 4]

// Sum all numbers
const sum = numbers.reduce((acc, num) => acc + num, 0);
console.log(sum); // 15
```

2. **Event Handlers**
Arrow functions maintain the `this` context in event handlers.

```javascript
class Button {
    constructor() {
        this.count = 0;
        this.button = document.createElement('button');
        this.button.textContent = 'Click me';
        this.button.addEventListener('click', () => {
            this.count++;
            console.log(this.count); // `this` refers to the Button instance
        });
        document.body.appendChild(this.button);
    }
}
const btn = new Button();
```

## Assignment Operators

Assignment operators in JavaScript are used to assign values to variables. The most common assignment operator is the simple assignment (`=`), but there are many other assignment operators that perform operations before assigning the value.

### Basic Assignment Operator

- **`=`**: Assigns the value on the right to the variable on the left.

  ```javascript
  let x = 10;
  ```

### Compound Assignment Operators

Compound assignment operators perform an operation on a variable and assign the result back to that variable.

1. **Addition Assignment (`+=`)**

   ```javascript
   let x = 5;
   x += 3; // Equivalent to x = x + 3
   console.log(x); // 8
   ```

2. **Subtraction Assignment (`-=`)**

   ```javascript
   let x = 5;
   x -= 3; // Equivalent to x = x - 3
   console.log(x); // 2
   ```

3. **Multiplication Assignment (`*=`)**

   ```javascript
   let x = 5;
   x *= 3; // Equivalent to x = x * 3
   console.log(x); // 15
   ```

4. **Division Assignment (`/=`)**

   ```javascript
   let x = 9;
   x /= 3; // Equivalent to x = x / 3
   console.log(x); // 3
   ```

Let's break down each of these topics in JavaScript: logical operators, template literals, class declarations, and loops/iterations.

## Logical Operators

Logical operators are used to combine multiple conditions or to invert a condition in JavaScript. The primary logical operators are `&&` (AND), `||` (OR), and `!` (NOT).

1. **Logical AND (`&&`)**
   - Returns `true` if both operands are `true`. Otherwise, returns `false`.

   ```javascript
   const a = true;
   const b = false;
   console.log(a && b); // false
   console.log(a && true); // true
   ```

2. **Logical OR (`||`)**
   - Returns `true` if at least one of the operands is `true`. Otherwise, returns `false`.

   ```javascript
   const a = true;
   const b = false;
   console.log(a || b); // true
   console.log(b || false); // false
   ```

3. **Logical NOT (`!`)**
   - Inverts the boolean value of its operand.

   ```javascript
   const a = true;
   console.log(!a); // false
   const b = false;
   console.log(!b); // true
   ```

## Template Literals

Template literals are a way to work with strings in JavaScript. They allow for embedding expressions and multi-line strings more easily than with traditional string concatenation.

1. **Basic Usage**
   - Enclosed by backticks (`` ` ``) instead of single or double quotes.

   ```javascript
   const name = 'Alice';
   console.log(`Hello, ${name}!`); // Hello, Alice!
   ```

2. **Multiline Strings**
   - Preserve the formatting of multi-line strings without the need for concatenation.

   ```javascript
   const message = `This is a
   multi-line string`;
   console.log(message);
   // This is a
   // multi-line string
   ```

3. **Expression Interpolation**
   - Embed expressions inside `${}`.

   ```javascript
   const a = 10;
   const b = 20;
   console.log(`${a} + ${b} = ${a + b}`); // 10 + 20 = 30
   ```

## Class Declarations

Classes in JavaScript are templates for creating objects. They encapsulate data with code to work on that data. ES6 introduced a more convenient syntax for class declarations.

1. **Basic Class Declaration**

   ```javascript
   class Person {
       constructor(name, age) {
           this.name = name;
           this.age = age;
       }

       greet() {
           console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
       }
   }

   const alice = new Person('Alice', 30);
   alice.greet(); // Hello, my name is Alice and I am 30 years old.
   ```

2. **Inheritance**
   - Classes can extend other classes.

   ```javascript
   class Employee extends Person {
       constructor(name, age, jobTitle) {
           super(name, age);
           this.jobTitle = jobTitle;
       }

       describeJob() {
           console.log(`I am a ${this.jobTitle}.`);
       }
   }

   const bob = new Employee('Bob', 25, 'Developer');
   bob.greet(); // Hello, my name is Bob and I am 25 years old.
   bob.describeJob(); // I am a Developer.
   ```

## Loops/Iterations

JavaScript provides several ways to iterate over data structures.

1. **for Loop**

   ```javascript
   for (let i = 0; i < 5; i++) {
       console.log(i);
   }
   // 0, 1, 2, 3, 4
   ```

2. **while Loop**

   ```javascript
   let i = 0;
   while (i < 5) {
       console.log(i);
       i++;
   }
   // 0, 1, 2, 3, 4
   ```

3. **do...while Loop**

   ```javascript
   let i = 0;
   do {
       console.log(i);
       i++;
   } while (i < 5);
   // 0, 1, 2, 3, 4
   ```

4. **for...of Loop**
   - Iterates over iterable objects (like arrays).

   ```javascript
   const array = ['a', 'b', 'c'];
   for (const item of array) {
       console.log(item);
   }
   // 'a', 'b', 'c'
   ```

5. **for...in Loop**
   - Iterates over the enumerable properties of an object.

   ```javascript
   const obj = { name: 'Alice', age: 30 };
   for (const key in obj) {
       console.log(`${key}: ${obj[key]}`);
   }
   // name: Alice, age: 30
   ```

6. **Array.prototype.forEach()**
   - Executes a provided function once for each array element.

   ```javascript
   const array = [1, 2, 3];
   array.forEach(item => {
       console.log(item);
   });
   // 1, 2, 3
   ```

## Conditional Operators

### 1. `if...else` Statements

The `if...else` statement executes a block of code if a specified condition is true. If the condition is false, another block of code can be executed using `else`.

**Syntax:**

```javascript
if (condition) {
    // block of code to be executed if the condition is true
} else {
    // block of code to be executed if the condition is false
}
```

**Example:**

```javascript
const age = 18;

if (age >= 18) {
    console.log("You are an adult.");
} else {
    console.log("You are a minor.");
}
```

### 2. `else if` Statements

The `else if` statement allows you to specify a new condition if the first condition is false.

**Syntax:**

```javascript
if (condition1) {
    // block of code to be executed if condition1 is true
} else if (condition2) {
    // block of code to be executed if condition2 is true
} else {
    // block of code to be executed if none of the conditions are true
}
```

**Example:**

```javascript
const score = 85;

if (score >= 90) {
    console.log("Grade: A");
} else if (score >= 80) {
    console.log("Grade: B");
} else if (score >= 70) {
    console.log("Grade: C");
} else {
    console.log("Grade: F");
}
```

### 3. Ternary Operator

The ternary operator is a shorthand way to write an `if...else` statement. It takes three operands: a condition, an expression to execute if the condition is true, and an expression to execute if the condition is false.

**Syntax:**

```javascript
condition ? expr1 : expr2
```

**Example:**

```javascript
const age = 18;
const canVote = (age >= 18) ? "Yes, you can vote." : "No, you cannot vote.";
console.log(canVote); // "Yes, you can vote."
```

### 4. `switch` Statement

The `switch` statement is used to perform different actions based on different conditions. It can be used as an alternative to multiple `if...else if` statements.

**Syntax:**

```javascript
switch (expression) {
    case value1:
        // code to be executed if expression === value1
        break;
    case value2:
        // code to be executed if expression === value2
        break;
    // additional cases
    default:
        // code to be executed if none of the cases match
}
```

**Example:**

```javascript
const fruit = "apple";

switch (fruit) {
    case "banana":
        console.log("Banana is yellow.");
        break;
    case "apple":
        console.log("Apple is red.");
        break;
    case "orange":
        console.log("Orange is orange.");
        break;
    default:
        console.log("Unknown fruit.");
}
```
