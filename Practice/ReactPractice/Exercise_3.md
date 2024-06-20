# Exercise 3 - Lists and Keys

## Description

This exercise involves the creation of a component that will display an array of data. You will need to create some dummy data in an array to display to the page. You will need to use the `map` function to take each element of the array and display it to the page.

## Approach

1. Create a new function React TSX Component called "Lists".
2. The component should have some dummy data in an array to display to the page.
3. Use the `map` function on the array in the `return` and create an arrow function that will `return` the TSX needed to display an item in the array
4. You should add a `key` property to the elements of the page that is some kind of unique identifier. Index is a valid option.

## Hints

- The component is focused purely on displaying data, it is fine to hard code in values just to display information
- The component should be a functional component and it needs to be exported, use the snippet `rfce` to generate the boiler plate for you
- The component needs to be imported into your `App.tsx` and written like an HTML element
- The map function on an array needs to be inside your `return` for the component

```typescript
return(
    {
        dummyArrayData.map((obj, index) => {
            return (
                <div key={index}>
                    // Display data in some way here
                </div>
            );
        })
    }
);
```
