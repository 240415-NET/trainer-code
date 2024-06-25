import React from 'react';
import Home from './Home';
//Importing fireEvent, that is going to let us simulate users cliking/interacting with our component
import { render, screen, fireEvent, queryByAttribute } from '@testing-library/react';
//Importing our message context provider, so we can render our component with the Message context 
//available/given to it
import MessageContextProvider from '../../context/MessageContext';


//Our first test, will ensure our component is rendering properly.
//Including the message that comes in via the context
test('Renders Home component, including context message', () => {
    //Rendering our home component, wrapping it in the MessageContextProvider
    render(
        <MessageContextProvider>
            <Home />
        </MessageContextProvider>
    );

    expect(screen.getByText('Hello from my MessageContext.tsx!')).toBeInTheDocument();
});

//This test will use fireEvent() to simulate a user clicking on our button
//We will also provide some new simulated user input in our text input field
test('Updates context message on button click', () => {
    //Again, we will render our component wrapped by the MessageContextProvider
    render(
        <MessageContextProvider>
            <Home />
        </MessageContextProvider>
    );

    //Now we will select our input field and out button so that we can work with them using fireEvent()
    const messageUpdateInput = screen.getByRole('textbox'); //Selecting our text box
    const messageUpdateButton = screen.getByRole('button', {name: /update message/}); //select our button



});