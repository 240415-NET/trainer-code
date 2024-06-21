# Exercise 6 - useEffect

## Description

This exercise will involve the creation of a component that uses the `useEffect` hook to make an API call when the component first loads. You will display the fetched data within the component.

## Approach

1. Create a new function React TSX Component called "DataFetcher".
2. The component should fetch data from an API when it first loads.
    - You can use `Axios` or `Fetch`
3. Use the `useEffect` hook to perform the API call.
4. Use the `useState` hook to manage the fetched data and loading state.
5. Display the component on the web page using the `App.tsx`.
6. Ensure the component correctly displays the fetched data or a loading indicator while the data is being fetched.

## Hints

- The component should be focused on demonstrating the use of the `useEffect` hook for making API calls.
- You should use `useState` to manage the state of the fetched data and the loading state.
- The component should be imported into your `App.tsx` and displayed like an HTML element.

```typescript
// interface used to describe the shape of the api response
interface Data {
    name: string,
    value: number
}

//state variable storing the state
let [data, setData] = useState<Data | undefined>(undefined);

// async function to get the data
async function getData(){
    let response = await axios.get('EXAMPLE URL');
    setPokemon(response.data);
}

// useEffect to do the call when the component loads
useEffect(() => {
    getData();
}, []);

```

