import React from 'react';
import Home from './Home';
//Importing fireEvent, that is going to let us simulate users cliking/interacting with our component
import { render, screen, fireEvent} from '@testing-library/react';
//Importing our message context provider, so we can render our component with the Message context 
//available/given to it
import MessageContextProvider from '../../context/MessageContext';
