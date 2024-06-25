// src/components/NavBar.test.tsx

import React from 'react';
import { render } from '@testing-library/react';
import { MemoryRouter } from 'react-router-dom';
import NavBar from './NavBar';

test('renders navigation links', () => {
  const { getByText } = render(
    <MemoryRouter>
      <NavBar />
    </MemoryRouter>
  );

  expect(getByText('Home')).toBeInTheDocument();
  expect(getByText('About')).toBeInTheDocument();
  expect(getByText('Dashboard')).toBeInTheDocument();
});
