import React from 'react'

//We will leverage typescript's type system, and make sure that we get objects to render
//that conform to our specification of an item for our app
interface Item {
  userId: string;
  itemId: string;
  category: string;
  originalCost: number;
  purchaseDate: Date;
  description: string;
}

//This is an additional interface contain the list of items that we will pass as a prop 
//from UserInfo to ItemList
interface ItemListProps {
  itemsFromUserInfo: Item[];
}


//ItemList receives an "argument", called a Prop in react, from it's parent UserInfo
function ItemList({itemsFromUserInfo}: ItemListProps) {



  return (
    <div>ItemList</div>
  )
}

export default ItemList