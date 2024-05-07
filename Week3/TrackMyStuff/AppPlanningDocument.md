# TrackMyStuff Planning Document

## I want to...

- Create a C# Console App
- User interactions through the console with exception handling
- Single User
- Persist data to a local file on my machine*
- Separate my code/logic into 3-4 layers. (Presentation (UI the user sees), Data Access (Communicating with our data store), Controllers/Business Logic, Models)

## Application Ideas

### Home Inventory/Receipt tracker (More code)

- Accounts for more than one user's stuff
- Different categories of items (Furniture, Clothes, etc)
- Storing the original value of the items
- description
- Date of Purchase on the items

### Drivers on auto policies (Less classes/models, but we have to account for relationships.)

(Saving this for later)

- Individual policy objects/info (One to many)
- Drivers associated with that policy

## Track My Stuff

### Models (What are we trying to store/work with)

- User
  - userId (int)
  - userName (string)

- Item - Things Common to most/all item types (This is our parent/super class)
  - itemId (int/maybe guid)
  - ownerId (int referencing someone's userId)
  - item category (string)
  - Original Cost (double)
  - Purchase Date (DateTime)
  - Description (string)

- Pets - inherit/extends our base Item class
  - name (string)
  - species (string)
  - age (int)

- Documents - inherit/extends our base Item class
  - Document Type (string)
  - Expiration Date (DateTime)

### User Stories/Features

- As a User I want to be able to create a profile and log in
  - ~~Present options via a menu in the console to the user (Presentation layer)~~
  - ~~ We want to take their input and either (Presentation layer) ~~
    - ~~create a new profile with a given username, and an auto-generated userID (business logic/controller)~~
      - ~~ we need to then store this profile in our data store (data access layer) ~~
      - ~~ if a given username already exists, prompt the user to provide a different username ~~
  
#### Group Activity

    - OR we want to pull up their information so they can LOG IN (business logic/controller)
      - we need to reach into our data store (file, or DB, etc) and grab their profile and associated info (data access layer).

Given this chunk of of our user story (Log in a user), I want each group to do the following:

  1. Pull trainer code if you have not already
  2. One person from the group, create a new branch (Group1, Group2, Group3, etc) using the git branch command (do not work in the main branch)
  3. Write the code needed in our different layers (Presentation, Data Access, Controller) to "log in" a user
     1. Have the user provide a username
        1. If the username is found, print out the fields in the user object to the console
        2. If it is not found, inform the user that the username wasn't found and have them try again

  Try to push your Group's branch to the trainer-code repo
  