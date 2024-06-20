import React from 'react';
import logo from './logo.svg';
import Login from './components/Login';
import UserInfo from './components/UserInfo';
import './App.css';

function App() {
  return (
    <div className="App">
      <Login />
      <UserInfo />
    </div>
  );
}

export default App;
