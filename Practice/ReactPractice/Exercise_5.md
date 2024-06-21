# Exercise 5 - useState

## Description

This exercise will involve the creation of a component that uses the `useState` hook to manage the state within a functional component. You will create input elements that will interact with the state, and the state will update based on user interactions.

## Approach

1. Create a new function React TSX Component called "StatefulComponent".
2. The component should have input elements such as buttons and input text.
3. Use the `useState` hook to create state variables within the component.
4. Display the component on the web page using the `App.tsx`.
5. Add functions to update the state when events are triggered.
6. Connect those functions to the HTML elements via their event properties.
7. Test to ensure they are functioning correctly.

## Hints

- The component should be focused on demonstrating the use of the `useState` hook.

```typescript
// examples
const [stateVariable, setStateVariable] = useState('defaultValue');
const [text, setText] = useState("");
const [clickCount, setClickCount] = useState(0);

// using them
// function to handle text input change
function handleInputChange(event: any) {
    setText(event.target.value);
}

// function to handle button click
function handleButtonClick() {
    setClickCount(clickCount + 1);
}
```

- You should have at least one button and one input text element that interacts with the state.

```typescript
<p>Input Text: {text}</p>
<input type="text" value={text} onChange={handleInputChange} />

<p>Button Clicked: {clickCount} times</p>
<button onClick={handleButtonClick}>Click Me</button>
```

- The component should be a functional component, and within it should be the state variables and functions that update the state.
