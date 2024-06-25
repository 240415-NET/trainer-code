import React, {useContext}from 'react'
import { MessageContext } from '../context/MessageContext'


function Dashboard() {

  const {message, setMessage} = useContext(MessageContext)!;

  return (
    <div>
      <h2>Dashboard</h2>
      <p>Welcome to the dashboard.</p>
      <p>{message}... but this time in my Dashboard component!</p>
      <p>Welcome to the dashboard. Imagine some cool business stuff here 
        with graphs and all that.
      </p>
    </div>
  )
}

export default Dashboard