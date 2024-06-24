//To use refs and context we have to import them
import React, { useContext , useRef } from 'react'

//I also have to import my context (hint: not the provider! Just the context.)
import { MessageContext } from '../context/MessageContext'

function Home() {






  return (
    <div>
      <h2>Home</h2>
      {/* In my p tag below, I will display the message from context */}
      <p></p>
      {/* Input field that will update my ref */}
      <input type="text" />
      {/* Button that will update my message */}
      <button onClick={}>Update Message</button>
    </div>
  )
}

export default Home