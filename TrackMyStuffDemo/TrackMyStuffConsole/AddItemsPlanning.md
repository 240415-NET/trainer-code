### As a user, I want to be be able to add my individual items, and have them persisted/associated to my account (Group 2)

## Presentation Layer
- ~~ItemCreation method should be made~~
- ~~ItemCreation should be passed the currentUser~~
- ~~User log in will call item functionality menu and pass Current User to persist data~~
## Controllers
- ~~New controller to:~~
    - ~~Create Item~~
- ~~New interface for data access independence~~
## Data Access
- Need to write JSON file
    - ~~for Items~~
    - for Pet
    - for Document
## Problem Solving
- Three separate files will be created
    - ~~Items (non-Pet, non-Document)~~
        - ~~ItemsFile.json~~
        - ~~Created by StoreItem(Item item)~~
        - ~~Called by NewOther~~
            - ~~User will be prompted for all values~~
    - Pet
        - PetsFile.json
        - Created by StorePet(Pet pet)
        - Called by NewPet()
            - User will be prompted for all values
    - Document
        - DocumentsFile.json
        - Created by StoreDocument(Document document)
        - Called by NewDocument()
            - User will be prompted for all values
