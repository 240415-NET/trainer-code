import React from 'react';
import { render, screen } from '@testing-library/react';
import MessageContextProvider, {MessageContext} from './MessageContext';

//To test a context, we need to create a test component to receive that context
function TestComponent() {
    //This component is like any other, except we will only work with it inside of our test suite
    //for the tests written inside of this test.tsx file. We bring in the context like any other component
    //that uses it
    const {message, setMessage} = React.useContext(MessageContext);

    //Now we will call useEffect to set a test message into our context for our test component
    React.useEffect(() => {
        setMessage('Test Message');
    }, [setMessage]);

    return( //Our test component will return some html that contains our message from our context
        //It should contain the "Test Message" that we set above
        <div>{message}</div>
    );
}

