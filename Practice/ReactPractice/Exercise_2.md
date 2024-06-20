# Exercise 2 - Events

## Description

This exercise will involve the creation of a component, and binding events to different HTML elements within the component. Functions will need to be created inside the component function, and elements will need to be created that are connected via the event binding.

## Approach

1. Create a new function React TSX Component called "Events".
2. The component should have some Input elements like buttons and input text.
3. Display the component to the web page using the `App.tsx`
4. Add functions to be ran when events are triggered.
5. Connect those functions to the HTML elements via their event properties.
6. Test to make sure they are functioning correctly.

## Hints

- The component is focused purely on events and input elements. You should have at least a button and some kind of input text element.
- The component should be a functional component and within it should be the functions that will be called when an event is triggered.

```typescript
// functional component
function Events(){
    // function to be called on a click event
    function clickEventHandler(){
        console.log("click");
    }
    return(
        <div>Events</div>
    );
}
```

- An element must have the event properties added to it and referencing the function to be called

```typescript
<button onClick={clickEventHandler}>Button</button>
```

- To handle the input text handler, we have to accept an event parameter for the function

```typescript
function inputChanged(event: any){
    console.log(event.target.value);
}
```

- The component needs to be imported into your `App.tsx` and written like an HTML element
