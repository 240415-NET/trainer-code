import React from 'react';
import { createContext, useState, ReactNode } from 'react';


//Defining an interface for our context value
interface MessageContextType {
    message: string; //the message that will be shared/displayed around our app
    setMessage: (message: string) => void; //Function that acts as a setter to update our message
}

//Creating a default context value, so that our context can not be null or undefined
// const defaultMessageContextValue: MessageContextType = {
//   message: 'Hello from context!',
//   setMessage: () => {}
// }

//Create a context with some (or null) default value that is then exported
//In order to use context, we create and export 2 things: The context, and it's contextProvider
//Creating our message context, and passing it the default value to avoid null or undefined in the context
export const MessageContext = createContext<MessageContextType>({
  message: 'Hello from context!',
  setMessage: () => {}
});

//Here we will define props for our context provider 
//We are going to use the ReactNode type (comes in with React) to simplify this
interface MessageContextProviderProps {
    children: ReactNode;
}

function MessageContextProvider( {children}: MessageContextProviderProps ) {

    //Inside of our MessageContextProvider functional component we will save state information
    const [message, setMessage] = useState<string>('Hello from my MessageContext.tsx!');

  return (
    <MessageContext.Provider value={{ message , setMessage }}>
        {children}
    </MessageContext.Provider>
  )
}

//Exporting our message context provider
export default MessageContextProvider;