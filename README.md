# PROG7312_Part1
---------- The Application ----------

--------------------------------------------------------------------------------------------------------------------------------------------

CREATOR: 	   Gabriel Grobbelaar
PLATFORM: 	   C#, Visual Studio 2022
APPLICATION TYPE : Windows Forms
.NET Framework	 : 4.8
--------------------------------------------------------------------------------------------------------------------------------------------

---------- DESCRIPTION ---------- 

The application is designed to teach librarians how to be able to sort call numbers in numerical and alphabetical order.

When the application is launched; it will present a home screen.
There are three menu buttons from which the user can user to navigate upon. 
1. Replace Books
2. Identify Areas (inactive)
3. Finding Call numbers (inactive)
4. EXIT

1. Upon clicking the Replace books button, a new form will be loaded with a user control over it. The new form will allow
   the user to place books on a bookshelf. The books will be generated in the bottom shelf. The user will have to order 
   the books in ascending order according to their labels contents.
   
2. In-order to interact with the books, the user will have to click on the start button. A timer will begin in seconds, 
   the user will now be able to drag and drop the books onto the topshelf. If the user is not happy with their placements;
   they can right click on the book and it will retrun to its original location on the bookshelf. i.e the bottom shelf. 

3. However, should the user feel lost, there is a help button with images which can help them navigate and understand the 
   application. When the user is satisfied with their placements, they can continue to click on Submit. The submit button
   will validate their placements and check whether the books are placed correctly. Thereafter, they will recieve a 
   message box that will indicate their score out of 10. 

4. After clicking ok in the message box, they can either click on Restart?; Reset Books; Main menu or View Results.

5. Restart button will reset the books to the bottom shelf, set the timer to zero and the books will recieve newly
   generated labels.

6. Reset books will keep the same label of books, however the timer will be set to zero and place the books back 
   down to the bottom shelf. 

7. View Results will product a dialog windom form which will produce a dataset of all the users attempts with the
   amount of correct placements and the time associated to that attempt. The best attempt with the most correct books in
   the shortest amount of time will be displayed to the user. 

8. Main menu will return the user to the Main menu where they can launch book replacements or exit the application
   entirely.


---------- HOW TO RUN ---------- 

You would need Visual Studio with C# and the .net framework installed!

The Folder of the application may be zipped or unzipped.

ZIPPED:	When the folder of the solution is zipped, you would have to place the zipped folder into another folder (Neater method)
	or on your desktop, then extract the files. 

UNZIPPED: Once extracted, open Visual Studio, you will be prompted to open a clone
	  repository, project/solution, local folder or create a new project. For this you would select "open a project or solution"
	  The next window will then ask you to navigate to the requested folder. You must select the folder where the project was 
	  unzipped/desktop. You will see the name of the application followed by a ".sln" <-- (solution). Once it is double clicked 
	  Visual Studio will open the solution. When the solution is displayed, press (CTRL + F5), this will launch the application 
	  without the debugger. Else, you may launch it with the debugger.

---------- APPLICATION extra ----------

The application makes use of a .dll to calculate the books positioning. 
An NuGet Package: Control.Draggable was added version: 1.0.5049.269

GitHub HTTPS link: https://github.com/GabrielGrobb/PROG7312_Part1.git
       SSH link  : git@github.com:GabrielGrobb/PROG7312_Part1.git
       GitHub CLI: gh repo clone GabrielGrobb/PROG7312_Part1
 



--------------------------------------------------------------------------------------------------------------------------------------------
