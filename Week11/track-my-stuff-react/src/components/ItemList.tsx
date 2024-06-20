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
    <div id='item-list-container'>
      <ol id='item-list'>
        {/* Here I will use the javascript array.map() method to render my line items based on the item list 
        that is passed in as a prop when this component is rendered. */}
        {/* Lists in react expect something from each item in the list - a key. Think of it as a primary key
        that react can use to refer to each item that we are going to dynamically render */}
        {itemsFromUserInfo.map((individualItem)  => (
            <li key={individualItem.itemId}>
              {individualItem.category} - {individualItem.description} - {individualItem.originalCost}
            </li>
        ))}
      </ol>
    </div>
  )
}

export default ItemList