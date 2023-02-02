# CST-150 Milestone Project

UPDATE 2023/2/2
Milestone 5
Added an extra form for the Remove() method.  Now it prompts the user: "Are you sure you want to remove {item.name} 'Yes' or 'Cancel'.  Also, I adjusted the Refresh() method in the MainInventoryForm so that the list of items that are displayed are populated based on what is in the search text box.  Before this change, when any of the sort buttons were pushed, the entire list of items would be displayed and it would ignore what was inside of the search text box.  Now, it will only populate a list based on what is inside of the search text box.  
If I had more time, I would learn how to make the ListBox look nicer with differnt columns and headings.

UPDATE 2023/2/2
Milestone 4
Fixed the exception handling when navagating between forms.  I learned how to adjust the DialogResult() to different results that the original calling form can understand.  So when everything is input correctly, the result is "OK" and then the Main form will continue, otherwise the Edit or Order forms will stay in front and will prompt the user to enter the correct type os input.
I would like to adjust the sort methods to no populate the entire list of items when there is text in the search box.

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
