// src/context/AppContext.test.tsx

import React from 'react';
import { render, screen } from '@testing-library/react';
import MessageContextProvider, { MessageContext }  from './MessageContext';

function TestComponent() {
  const { message, setMessage } = React.useContext(MessageContext)!;
  React.useEffect(() => {
    setMessage('Test Message');
  }, [setMessage]);
  return <div>{message}</div>;
}

test('provides default message', () => {
  render(
    <MessageContextProvider>
      <TestComponent />
    </MessageContextProvider>
  );
  expect(screen.getByText('Test Message')).toBeInTheDocument();
});
