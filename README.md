# CST-150 Milestone Project

UPDATE 2023/1/29
Milestone 3
Added InventoryManager class, implimented sorting, implimented search.
When I updated the option for the Main form to wait for the DialogResult from the other forms, it made a more streamline option for adding and editing the Items.  However, it broke the Exception handling that I had in place to prevent incorrect input type.  Now, when there is an incorrect input type, the form just closes and returns to the main page.

UPDATE 2023/1/15
Milestone 2
Added Item Class, populated Item objects into the list box.  Finished option to add a new item with the button.  Edit item works, but I could not figure out how to re-load the edited information into the list box after it was edited.  So, instead, I made the edit item option replace the selected item instead of just editing it.  Remove item works great.  
I added exception handling if there are no items selected.  I also added a method to select the first item in the list box.
During this assignment, I learned how to pass information between forms.
If I had more time(and knowledge) I would like to make the edit item option actually edit the item instead of just replacing it.


Inventory application that will contain an Item class and Inventory Class.
Item class will be used to create Item objects with a name, price, and quantity.
Inventory class will be used to create a list of, sort, search, add, remove and edit Item objects.
