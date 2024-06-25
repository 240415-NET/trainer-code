// src/components/Home.test.tsx

import React from 'react';
import { render, fireEvent, screen } from '@testing-library/react';
import  MessageContextProvider from '../context/MessageContext';
import Home from './Home';

test('renders default context message', () => {
  render(
    <MessageContextProvider>
      <Home />
    </MessageContextProvider>
  );
  expect(screen.getByText('Hello from Context!')).toBeInTheDocument();
});

test('updates context message on button click', () => {
  render(
    <MessageContextProvider>
      <Home />
    </MessageContextProvider>
  );

  const input = screen.getByRole('textbox');
  const button = screen.getByRole('button', { name: /update message/i });

  fireEvent.change(input, { target: { value: 'New Message' } });
  fireEvent.click(button);

  expect(screen.getByText('New Message')).toBeInTheDocument();
});
