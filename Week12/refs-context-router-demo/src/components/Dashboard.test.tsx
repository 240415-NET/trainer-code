// src/components/Dashboard.test.tsx

import React from 'react';
import { render, screen } from '@testing-library/react';
import Dashboard from './Dashboard';

test('renders dashboard page', () => {
  render(<Dashboard />);
  expect(screen.getByText('Dashboard')).toBeInTheDocument();
  expect(screen.getByText('Welcome to the dashboard.')).toBeInTheDocument();
});
