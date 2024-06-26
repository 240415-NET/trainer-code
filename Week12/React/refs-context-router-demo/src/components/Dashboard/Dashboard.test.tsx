//This test file, will test our About component
//It will make sure that we are rendering it properly.
import React from 'react';
//We import the component that is under test in this file
import Dashboard from './Dashboard';
//We import what we need from the react testing library we just npm installed
import { render, screen } from '@testing-library/react'

test('Correctly renders About component', () => {
    render(<Dashboard/>);
    expect(screen.getByText('Dashboard')).toBeInTheDocument();
    expect(screen.getByText('Welcome to the dashboard.', {exact: false})).toBeInTheDocument();
});