//To use refs and context we have to import them
import React, { useContext , useRef } from 'react'

//I also have to import my context (hint: not the provider! Just the context.)
import { MessageContext } from '../context/MessageContext'

function Home() {

  //Accessing context (MessageContext in this case) with the useContext hook
  //The exclamation point at the end before my semicolon tells me that context may be null or undefined
  //If I just opened my application, there may be nothing there at all!
  const {message, setMessage} = useContext(MessageContext)!;

  //Creating a ref to hold the input element reference
  const inputRef = useRef<HTMLInputElement>(null);

  //Function to update the context message using the input value
  function updateContextMessage() {
    if (inputRef.current) { //If there is something currently in out inputRef
      setMessage(inputRef.current.value);//... give it the current value of inputRef
    }
  }

  return (
    <div>
      <h2>Home</h2>
      {/* In my p tag below, I will display the message from context */}
      <p></p>
      {/* Input field that will update my ref */}
      <input type="text" ref={inputRef}/>
      {/* Button that will update my message */}
      <button onClick={updateContextMessage}>Update Message</button>
    </div>
  )
}

export default Home