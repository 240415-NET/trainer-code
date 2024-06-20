# Exercise 4 - Props

## Description

This exercise will involve the creation of a parent and child component. We are working on passing data from the parent component into the child component using `props`.

## Approach

1. Create a new function React TSX Component called "ChildComponent" and "ParentComponent".
2. The `ChildComponent` should be nested inside the `ParentComponent`.
3. The `ChildComponent` function parameter should be expecting `props`. This is passed into it by the `ParentComponent`.
4. The `ChildComponent` should use the props passed into it by the parent in some meaningful way.

## Hints

- The parent component is effectively wrapping around the child component, with its main goal being to pass data to the child component in the form of `props`.

```typescript
// parent component

function ParentComponent(){

    return(
        <>
            <ChildComponent data="something"/>
        </>
    );
}

```

- The child component will be expecting the data from the parent in the form of a parameter in the function.

```typescript

function ChildComponent(props: any){
    console.log(props);
    return(
        <div>ChildComponent</div>
    );
}

```

- The child component should use the props passed into it in some kind of meaningful way, that is up to you.
