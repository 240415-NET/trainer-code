//This test file, will test our About component
//It will make sure that we are rendering it properly.
import React from 'react';
//We import the component that is under test in this file
import About from './About';
//We import what we need from the react testing library we just npm installed
import { render, screen } from '@testing-library/react'

test('Correctly renders About component' , () => {
    //We are going to use "render" to render out component, referncing it with it's react 
    //HTML element tag
    render(<About/>);
    expect(screen.getByText('About')).toBeInTheDocument();
    expect(screen.getByText("This is the about page.")).toBeInTheDocument();
});