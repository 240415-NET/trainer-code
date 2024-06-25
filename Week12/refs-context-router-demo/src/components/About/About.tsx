import React, {useContext}from 'react'
import { MessageContext } from '../../context/MessageContext'

function About() {

  const {message, setMessage} = useContext(MessageContext)!;

  return (
    <div>
      <h2>About</h2>
      <p>This is the about page.</p>
      <p>{message}... but this time in my About component!</p>
      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean varius facilisis risus eu dictum. 
        Aenean et ipsum dapibus nulla imperdiet dapibus. Etiam dignissim pulvinar pharetra. Integer feugiat 
        quis nisl in rutrum. Mauris maximus, elit id sagittis lacinia, mi neque semper orci, sit amet 
        dictum nunc arcu nec erat.</p>
    </div>
  )
}

export default About