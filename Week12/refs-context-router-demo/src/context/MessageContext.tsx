import React from 'react';
import { createContext, useState, ReactNode } from 'react';


//Defining an interface for our context value
interface MessageContextType {
    message: string; //the message that will be shared/displayed around our app
    setMessage: (message: string) => void; //Function that acts as a setter to update our message
}

// Provide a default value for the context
const defaultContextValue: MessageContextType = {
  message: 'Hello from Context!',
  setMessage: () => {},
};

//Create a context with some (or null) default value that is then exported
//In order to use context, we create and export 2 things: The context, and it's contextProvider
export const MessageContext = createContext<MessageContextType>(defaultContextValue);

//Here we will define props for our context provider 
//We are going to use the ReactNode type (comes in with React) to simplify this
interface MessageContextProviderProps {
    children: ReactNode;
}

function MessageContextProvider( {children}: MessageContextProviderProps ) {

    //Inside of our MessageContextProvider functional component we will save state information
    const [message, setMessage] = useState<string>('Hello from Context!');

  return (
    <MessageContext.Provider value={{ message , setMessage }}>
        {children}
    </MessageContext.Provider>
  )
}

//Exporting our message context provider
export default MessageContextProvider;