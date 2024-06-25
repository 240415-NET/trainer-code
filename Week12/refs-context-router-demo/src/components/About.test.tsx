// src/components/About.test.tsx

import React from 'react';
import { render, screen } from '@testing-library/react';
import About from './About';

test('renders about page', () => {
  render(<About />);
  expect(screen.getByText('About')).toBeInTheDocument();
  expect(screen.getByText('This is the about page.')).toBeInTheDocument();
});
