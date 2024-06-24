import React from 'react';
import { createContext, useState, ReactNode } from 'react';



//Defining an interface for our context value
interface MessageContextType {
    message: string; //the message that will be shared/displayed around our app
    setMessage: (message: string) => void; //Function that acts as a setter to update our message
}

//Create a context with some (or null) default value that is then exported
//In order to use context, we create and export 2 things: The context, and it's contextProvider
export const MessageContext = createContext<MessageContextType | undefined>(undefined);




function MessageContextProvider() {


  return (
    <div>MessageContext</div>
  )
}

export default MessageContextProvider;