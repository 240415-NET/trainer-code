# React Review

To create a react app with typescript, the command is:

`npx create-react-app <name of directory> --template typescript`

* Overview
    - React is a JavaScript library for building user interfaces.
    - It follows a component-based architecture, allowing developers to build reusable UI components.
    - React uses a virtual DOM (Document Object Model) to improve the performance of updates and rendering.
    - React allows for the creation of single-page applications and mobile apps.
    - It integrates well with other libraries and frameworks, such as Redux for state management.
    - React uses a syntax extension of JavaScript called JSX, which allows for writing HTML-like code within JavaScript.
* Nested Components
    - Nested components refer to the practice of having components within other components in React.
    - Nested components allow for the creation of complex and modular user interfaces.
    - Each component can manage its own state and behavior, making it easier to maintain and update the codebase.
    - Nested components promote reusability and make the code more organized and easier to understand.
* Class Components
    - Class components are a way to define React components using ES6 classes.
    - Class components have a state, which is an object that holds data specific to a component.
    - Class components allow for the use of local state and lifecycle methods, making them suitable for more complex and dynamic user interfaces.
    - The render method is used to define what a component should display.
    - Class components can also update their state and re-render in response to user events or changes in data.
    - ```typescript
        import React, { Component } from "react";

        class ParentComponent extends Component {
            state = {
                message: "Hello from Parent Component"
            };

            render() {
                return (
                <div>
                    <ChildComponent message={this.state.message} />
                </div>
                );
            }
            }

            class ChildComponent extends Component {
            render() {
                return <h1>{this.props.message}</h1>;
            }
        }

        export default ParentComponent;
    
* Functional Components
    - Functional components are a way to define React components using functions.
    - Functional components have a state, which is an object that holds data specific to a component.
    - Functional components allow for the use of hooks, such as useState, useEffect, useContext, and useRefs.
    - The function's return is used to define what a component should display.
    - Functional components can also update their state and re-render in response to user events or changes in data.
    - ```typescript
        import React from 'react';

        function MyComponent(props) {
            return (
                <div>
                    <h1>{props.title}</h1>
                    <p>{props.description}</p>
                </div>
            );
        }

        export default MyComponent;


* One-Way Data Flow
    - One-way data flow, also known as unidirectional data flow, is a key concept in React.
    - It means that data flows in only one direction, from the parent component to its children components.
    - Children components cannot modify the data they receive, they can only render it.
    - One-way data flow is implemented through props, where parent components pass data to their children components as props.
    - If a child component needs to update the data, it must communicate this to its parent component, which will then update the data and pass it down again.
    - Props and State
        - `props` (properties) are inputs to a React component, passed down from its parent component.
        - `state` is an internal representation of a component's data and is managed within the component itself.
        - Props are read-only and cannot be changed within the component. If a component needs to change its data, it must use state.
        - State is updated using `setState` method, which triggers a re-render of the component.
        - When using state, it's important to only update state with `setState`, and not directly modify the state object.
        - ```typescript
            import React, { useState } from "react";

            function MyFunctionalComponent = ({ title }) => {
                const [count, setCount] = useState(0);

                const handleClick = () => {
                    setCount(prevCount => prevCount + 1);
                };

                return (
                    <div>
                    <h1>{title}</h1>
                    <p>Count: {count}</p>
                    <button onClick={handleClick}>Increase Count</button>
                    </div>
                );
            };

            export default MyFunctionalComponent;

    - Immutability
        - Immutability refers to the idea of not changing an object or data structure after it's created.
        - In React, it's important to avoid direct modification of props and state objects, as this can lead to unexpected behavior and bugs.
        - Instead, immutability should be maintained by creating new copies of objects with updated values.
        - React provides `setState` method to update the state in a way that's optimized for performance, and encourages immutability.
    - Validating Properties
        - Validation can be done using `PropTypes`, a library for type checking in React.
        - To use `PropTypes`, you can import the library and add a propTypes property to your component.
        - The propTypes property is an object that maps prop names to validation functions.
        - There are several built-in PropTypes for common data types, such as string, number, array, object, etc.
        - You can also create custom PropTypes for more complex validation requirements.
        - If a prop fails validation, a warning will be logged in the browser console.
        - ```typescript
            import React from "react";
            import PropTypes from "prop-types";

            function MyComponent = ({ title, count }) => {
                return (
                    <div>
                        <h1>{title}</h1>
                        <p>Count: {count}</p>
                    </div>
                );
            };

            MyComponent.propTypes = {
                title: PropTypes.string.isRequired,
                count: PropTypes.number.isRequired
            };

            export default MyComponent;

* Lists and Keys
    - Lists are a common component in React, used to render arrays of data.
    - In React, each item in a list should have a unique `key` prop, which helps React to optimize the update process when items are added, removed, or reordered.
    - The `key` prop should be a string that uniquely identifies the item within the list. It's often best to use a unique identifier from the data itself, such as an id field from a database.
    - When rendering lists, it's common to use the map function to iterate over the array and render each item as a separate component.
    - In this case, the `key` prop should be passed to the component for each item.
    - ```typescript
        import React from "react";

        function Item = ({ title, count }) => (
            <div>
                <h2>{title}</h2>
                <p>Count: {count}</p>
            </div>
        );

        function ItemList = ({ items }) => (
            <div>
                {items.map(item => (
                    <Item key={item.id} title={item.title} count={item.count} />
                ))}
            </div>
        );

        export default ItemList;
    > In this example, the Item component is a stateless component that takes title and count as props. The ItemList component maps over the items array and renders an Item component for each item, passing the title and count values as props, along with a unique key value.
* Event Handling
    - Event handling in React refers to the process of responding to user interactions with the UI, such as clicks, hover, etc.
    - In React, events are handled using event handlers, which are functions that are called in response to an event.
    - Event handlers can be defined as properties of a component, and can access the component's `props` and `state` in order to update the component in response to the event.
    - To bind an event handler to an event, you can use the on keyword followed by the event name, such as `onClick`, `onMouseOver`, etc.
    - When defining an event handler, you should use the bind method or an arrow function to ensure that this refers to the component instance.
    - Event handlers should also be kept as simple and focused as possible, to minimize complexity and make the component easier to test.
    - ```typescript
        import React, { useState } from "react";

        const Counter = () => {
            const [count, setCount] = useState(0);

            const handleClick = () => {
                setCount(count + 1);
            };

            return (
                <div>
                    <p>Count: {count}</p>
                    <button onClick={handleClick}>Increment</button>
                </div>
            );
        };

        export default Counter;
* Lifting State
    - "Lifting state up" is a common pattern in React where state is moved from a child component to its parent component, in order to allow the parent component to manage and update the state.
    - This pattern is useful when multiple child components need to share and update the same state. By lifting the state up to the parent component, it becomes easier to manage the state in a centralized location, and to ensure that updates to the state are consistent across all child components.
    - To lift state up, the parent component should define a method that updates the state, and pass this method as a prop to its child components. The child components can then call the method in response to user interactions or other events, in order to update the state.
    - The parent component should also render the child components, passing the relevant state data as props to each child component. This allows the child components to receive updates to the state whenever it changes.
    - ```typescript
        import React, { useState } from "react";

        const Counter = ({ count, onIncrement }) => (
            <div>
                <p>Count: {count}</p>
                <button onClick={onIncrement}>Increment</button>
            </div>
        );

        const CounterParent = () => {
            const [count, setCount] = useState(0);

            const handleIncrement = () => {
                setCount(count + 1);
            };

            return (
                <div>
                    <Counter count={count} onIncrement={handleIncrement} />
                </div>
            );
        };

        export default CounterParent;
    > In this example, the CounterParent component is the parent component that manages the count state. The Counter component is the child component that displays the count and provides a button for incrementing the count. The CounterParent component passes the count state and a handleIncrement method as props to the Counter component, allowing the Counter component to display the count and call the handleIncrement method in response to a click event. The handleIncrement method updates the count state using the setCount method, causing the component to re-render with the updated count value.

* Containment
    - The goal of containment is to allow components to be composed and reused, while avoiding tight coupling between components.
    - The children are isolated from the parent's implementation details, and are only concerned with rendering the data passed to them as props.
    - This makes components more reusable and composable, since they do not depend on the implementation details of their parent components.
    - Containment is achieved by using a combination of props, Higher Order Components, and render props, and is a fundamental principle in React for building scalable and maintainable applications.
* Specialization
    - Specialization is a pattern in React where a component is designed to handle a specific type of data, rendering or behavior.
    - The goal of specialization is to make components more reusable, predictable, and easier to maintain.
    - In specialization, a component is designed to handle a specific type of data, and it is expected to render that data in a certain way. This makes the component more predictable and easier to use, since it has a specific responsibility.
* Routing
    - To use `react-router` you must install it with npm
        - `npm install react-router-dom`
    - Routing is a feature in React that allows you to manage the navigation between different pages or views of your application.
    - The goal of routing is to provide a seamless and intuitive navigation experience for users, and to make it easy to navigate between different parts of an application.
    - In React, routing is typically implemented using a routing library such as `react-router`. This library provides a set of components and APIs for defining routes, navigating between routes, and managing the URL of your application.
    - The main components used in React routing are the Route, Link, and Router components. The Route component is used to define a mapping between a specific URL path and a component that should be rendered when that path is accessed. The Link component is used to navigate between routes by changing the URL of the application. The Router component is used to define the overall structure of your application's routing.
    - ```typescript
        import React from "react";
        import { BrowserRouter as Router, Route, Link } from "react-router-dom";

        const Home = () => <h2>Home</h2>;
        const About = () => <h2>About</h2>;
        const Contact = () => <h2>Contact</h2>;

        const App = () => (
            <Router>
                <nav>
                <ul>
                    <li>
                        <Link to="/">Home</Link>
                    </li>
                    <li>
                        <Link to="/about">About</Link>
                    </li>
                    <li>
                        <Link to="/contact">Contact</Link>
                    </li>
                </ul>
                </nav>
                <Route exact path="/" component={Home} />
                <Route path="/about" component={About} />
                <Route path="/contact" component={Contact} />
            </Router>
        );

        export default App;
    > In this example, the Router component is used to define the overall structure of the application's routing. The `Route` components are used to map URLs to components that should be rendered when those URLs are accessed. The `Link` components are used to navigate between routes by changing the URL of the application.
* Refs
    - Refs in React provide a way to access the properties of a DOM element directly from your JavaScript code.
    - Refs are created using the `createRef()` method and attached to React elements via the `ref` prop.
    - Refs are useful when you need to directly access the properties of an element, such as its position, size, or value, in order to perform some type of manipulation.
    - Refs should be used sparingly, as they can make your code less declarative and harder to understand.
    - There are two main types of refs in React: callback refs and `createRef()` refs.
    - ```typescript
        import React, { useRef } from 'react';

        const InputRefExample = () => {
            const inputRef = useRef(null);
            
            const handleClick = () => {
                inputRef.current.focus();
            };

            return (
                <div>
                    <input type="text" ref={inputRef} />
                    <button onClick={handleClick}>Focus Input</button>
                </div>
            );
        };

        export default InputRefExample;
    > In this example, a ref is created using the `useRef` hook and attached to the input element via the ref prop. The `handleClick` function is used to focus the input when the button is clicked. The value of the input can be accessed via `inputRef.current`.
* Hooks
    - Hooks are a feature in React that allow you to add state and other React features to functional components.
    - Prior to Hooks, adding state and other React features to functional components required the use of class components.
    - Hooks are named after the state or feature they provide, such as `useState`, `useEffect`, `useContext`, etc.
    - Hooks let you reuse stateful logic across your components, without having to write class components.
    - Hooks can only be called at the top level of your components or your own custom Hooks.
    - ```typescript
        import React, { useState } from 'react';

        const Counter = () => {
            const [count, setCount] = useState(0);

            return (
                <div>
                    <p>You clicked {count} times</p>
                    <button onClick={() => setCount(count + 1)}>
                        Click me
                    </button>
                </div>
            );
        };

        export default Counter;
    > In this example, the `useState` hook is used to add a state value `count` to the component. The hook returns an array containing the current state value `count` and a function `setCount` that can be used to update the state value. The `setCount` function is passed to the `onClick` prop of the button, which updates the count value each time the button is clicked.
* Axios
    - Axios is a popular JavaScript library used for making HTTP requests.
    - It provides a simple API for making both GET and POST requests to a server.
    - Axios supports a variety of features such as request and response interceptors, error handling, and transforming requests and responses.
    - To use Axios, you must install it with npm
        - `npm install axios`
    - ```typescript
        import React, { useState, useEffect } from 'react';
        import axios from 'axios';

        const API_URL = 'https://jsonplaceholder.typicode.com/posts';

        const Posts = () => {
            const [posts, setPosts] = useState([]);

            useEffect(() => {
                axios.get(API_URL)
                    .then(response => setPosts(response.data))
                    .catch(error => console.error(error));
            }, []);

            return (
                <ul>
                    {posts.map(post => (
                        <li key={post.id}>{post.title}</li>
                    ))}
                </ul>
            );
        };

        export default Posts;
    > In this example, the component makes a GET request to the JSON placeholder API using the `axios.get` method. The response from the API is then stored in the component's state using the `setPosts` function, which is passed as the first argument to `useState`. The component is then rendered with a list of post titles.
    - Axios vs Fetch
        - Axios and fetch are both libraries used for making HTTP requests in JavaScript.
        - Fetch is a native browser API for making HTTP requests, while Axios is a third-party library.
        - Both Axios and fetch allow you to make GET and POST requests, but Axios has more features and a more user-friendly API.
        - Axios supports request and response interceptors, automatic transformation of request and response data, error handling, and more.
        - Fetch does not have built-in error handling, and its API is less intuitive compared to Axios.
        - Axios is also more widely used and has better community support compared to fetch.
        - Here are some examples
            - Axios GET Request
                - ```typescript
                    import axios from 'axios';

                    const API_URL = 'https://jsonplaceholder.typicode.com/posts';

                    axios.get(API_URL)
                        .then(response => console.log(response.data))
                        .catch(error => console.error(error));
            - Fetch GET Request
                - ```typescript
                    const API_URL = 'https://jsonplaceholder.typicode.com/posts';

                    fetch(API_URL)
                        .then(response => response.json())
                        .then(data => console.log(data))
                        .catch(error => console.error(error));
* Context
    - The Context API in React is a way to manage state globally. It provides a way to pass data through the component tree without having to pass props down manually at every level.
    - Context is designed to share data that can be considered “global” for a tree of React components, such as the current authenticated user, theme, or preferred language.
    - To create a context, you use React.createContext. This creates a Context object. When React renders a component that subscribes to this Context object, it will read the current context value from the closest matching Provider above it in the tree.
    - A Context object comes with a Provider React component that allows consuming components to subscribe to context changes.
    - The Provider component accepts a value prop to be passed to consuming components that are descendants of this Provider. One Provider can be connected to many consumers.
    - To consume a context value, use the useContext hook. This hook accepts a context object (the value returned from React.createContext) and returns the current context value.
* Jest
    - Jest supports unit, integration, and end-to-end testing.
    - Jest has a rich set of features, including mocking, spying, and snapshot testing.
    - To setup Jest in your React Typescript project, we need to do the following
        1. Install Jest
            - `npm install --save-dev jest @types/jest ts-jest`
            - In the case that this fails, run it with `--force` as well
        2. Add the Jest config file `jest.config.json` in your root folder
            - ```json
                {
                    "transform": {
                        "^.+\\.tsx?$": "ts-jest"
                    }
                }
        3. Now you can create your tests, make sure to name them with the `fileName.test.tsx` as the `.test` is needed for jest to recognize it is a test
    - ```typescript
        import React from 'react';
        import { render } from '@testing-library/react';
        import App from './App';

        test('renders learn react link', () => {
            const { getByText } = render(<App />);
            const linkElement = getByText(/learn react/i);
            expect(linkElement).toBeInTheDocument();
        });
* React Testing Library
    - React Testing Library focuses on testing the behavior of a React component as a user would interact with it, rather than testing its internal implementation details.
    - React Testing Library encourages developers to write tests that are simple, easy to understand, and maintainable.
    - It is framework agnostic, meaning it can be used with any testing framework, not just Jest.
    - To use React Testing Library, follow these steps
        1. Install React Testing Library using npm
            - `npm install --save-dev @testing-library/react @testing-library/jest-dom jest-environment-jsdom
        2. Update your `jest.config.json` file
            - ```json
                {
                    "testEnvironment": "jsdom",
                    "transform": {
                        "^.+\\.tsx?$": "ts-jest"
                    },
                    "setupFilesAfterEnv": [
                        "@testing-library/jest-dom/extend-expect"
                    ]
                }
    - ```typescript
        import React from 'react';
        import { render, screen } from '@testing-library/react';
        import App from './App';

        test('renders learn react link', () => {
            render(<App />);
            const linkElement = screen.getByText(/learn react/i);
            expect(linkElement).toBeInTheDocument();
        });
    > In this example, React Testing Library is used to test a React component called `App`. The `render` method from `@testing-library/react` is used to render the component, and the `screen` object provides access to the rendered output. The `getByText` method is used to find an element in the rendered output that matches the provided text, and an expectation is made that the element is present in the document.
