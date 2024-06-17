//We will still import React from 'react'
//But now for our class component, we need to import the Component base class
//that our component will inherit from
import React, { Component } from 'react';

//Class components cannot benefit from things like hooks, which means that we need to 
//manually store our own state. No easy useState to update our underlying under-the-hood State object

//Define an interface that will hold the component's state
interface CounterClassState {
    count: number;
}

//Here we will actually define our class component
class ClassBasedCounter extends Component<{}, CounterClassState> {

    constructor(props: {}) {
        //We can think of props as arguments to our components, whether class based or functional
        //Because this is a class component, we need to actually take in a props object argument
        //and pass it to the super() constructor we inherited from Component (prebuilt react class)
        super(props);

        //Additionally, we will set our state to 0
        //Specifically, we are setting count's value to 0 and storing count in our state
        //object, that belongs to our ClassBasedCounter 
        //Notice we lose access to things like setState(), and have to do this fairly manually
        this.state = { count: 0};
    }

    





}