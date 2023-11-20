PROG7312 POE

CREATOR: 	 	Gabriel Grobbelaar
PLATFORM: 	   	C#, Visual Studio 2022
APPLICATION TYPE:	Windows Forms
.NET Framework:	4.8
Contents
PROG7312 POE	1
DESCRIPTION	2
Replace Books	3
Identify Areas	4
Calling Numbers	5
HOW TO RUN	6
APPLICATION extra	6
Possible errors	7

 
DESCRIPTION 
NOTE: Should you want to play a different game, you would have to return to the main menu.
The application is designed to teach librarians how to be able to sort call numbers in numerical and alphabetical order.
When the application is launched; it will present a home screen.
There are three menu buttons from which the user can user to navigate upon. 
1. Replace Books
Upon clicking the Replace books button, a new form will be loaded with a user control over it. The new form will allow the user to place books on a bookshelf. The books will be generated in the bottom shelf. The user will have to order the books in ascending order according to their label’s contents.
2. Identify Areas
The application will randomly select which of the two, either descriptions or calling numbers to be matched to the top section.
Upon clicking the Identify Areas button, a new form will be loaded with a user control over it. The new form will allow the user to place panels from the bottom of the form on a column at the top of the form. The panels will be generated in the bottom shelf. The user will have to place the panels according to their label’s contents. Seven panels will be randomly generated in the bottom shelf; of the seven, only four will be correct. In the top section of the form, four calling numbers or descriptions will be generated.

3. Finding Call numbers
Upon clicking the Calling Number button, a new form will be loaded with a user control over it. The new form will allow the user to select radio buttons which correlate to panels at the bottom of the form. The panels will be generated with labels. The user will have to select a radio button that correlates to the correct panel. The labels of the panels will be random.
4. EXIT 
The application will close entirely.
 
Replace Books
1. In-order to interact with the books, the user will have to click on the start button. A timer will begin in seconds, the user will now be able to drag and drop the books onto the top-shelf. If the user is not happy with their placements; they can right-click on the book, and it will return to its original location on the bookshelf. i.e., the bottom shelf. 

2. However, should the user feel lost, there is a help button with images which can help them navigate and understand the application. When the user is satisfied with their placements, they can continue to click on Submit. The submit button will validate their placements and check whether the books are placed correctly. Thereafter, they will receive a message box that will indicate their score out of 10. 

3. After clicking ok in the message box, they can either click on “Restart?”; “Reset Books”; “Main menu” or “View Results”.

4. “Restart” button will reset the books to the bottom shelf, set the timer to zero and the books will receive newly generated labels.

5. “Reset books” will keep the same label of books; however, the timer will be set to zero and place the books back down to the bottom shelf. 

6. “View Results” will produce a dialog window form which will produce a dataset of all the users attempts with the number of correct placements and the time associated to that attempt. The best attempt with the most correct books in the shortest amount of time will be displayed to the user. 

7. “Main menu” will return the user to the Main menu where they can launch book replacements or exit the application entirely.

8. If the user needs to close the application immediately, an exit button will be located on the form.
 
Identify Areas
1. In-order to interact with the bottom panels, the user will have to click on the start button. A timer will begin in seconds, the user will now be able to drag and drop the panels towards the top section of the form. If the user is not happy with their placements and they have not placed the final panel; they can right-click on the panel, and it will return to its original location on the form. 

2. However, should the user feel lost, there is a help button with images which can help them navigate and understand the application. When the user is satisfied; they can place their final choice and the application will produce a score. 

3. After clicking ok in the message box, they can either click on “Reset?”, “Main menu” or “View Results”.

4. Reset will keep the same label of the panels; however, the timer will be set to zero and place the panels back down to the section. 

5. “View Results” will produce a dialog window form which will produce a dataset of all the users attempts with the number of correct placements and the time associated to that attempt. The best attempt with the most correct books in the shortest amount of time will be displayed to the user. 

6. Main menu will return the user to the Main menu where they can launch book replacements or exit the application entirely.

7. While the game is running, there is a pause button. Should the user wish to stop and take a break. The pause button will stop the timer. However, the user will not be able to see the game requests. 

8. While paused, a new button will appear; Resume. The resume button will allow the user to continue with their game and the timer will continue to tick.

9. If the user needs to close the application immediately, an exit button will be located on the form.
 
Calling Numbers
1. In-order to interact with the bottom panels, the user will have to click on the start button. A timer will begin in seconds, the user will now be able to click on the radio buttons. When the user has clicked on a radio button, they will be presented with a message indicating that their selection is correct or not. If it is correct, the next question will begin. If not, the user will have to keep trying until they click the correct option.

2. However, should the user feel lost, there is a help button with images which can help them navigate and understand the application. When the user is satisfied; they can place their final choice and the application will produce a score. 

3. After reaching the last question and clicking ok in the message box, they can either click on “Play Again?”, “Exit”, “Main menu” or “View Results”.

4. “Play Again” will reset the game with new label on the panels; however, the timer will restart, and the pause button will become available.

5. “Results” will produce a dialog window form which will produce a dataset of all the users attempts with the number of correct placements and the time associated to that attempt. The best attempt with the most correct books in the shortest amount of time will be displayed to the user. 

6. “Main menu” will return the user to the Main menu where they can launch book replacements or exit the application entirely.

7. While the game is running, there is a pause button. Should the user wish to stop and take a break. The pause button will stop the timer. However, the user will not be able to see the game requests. 

8. While paused, a new button will appear; Resume. The resume button will allow the user to continue with their game and the timer will continue to tick.

9. If the user needs to close the application immediately, an exit button will be located on the form.

 

HOW TO RUN
You would need Visual Studio with C# and the .net framework installed!
The Folder of the application may be zipped or unzipped.
ZIPPED:	When the folder of the solution is zipped, you would have to place the zipped folder into another folder (Neater method) or on your desktop, then extract the files. 
UNZIPPED: Once extracted, open Visual Studio, you will be prompted to open a clone repository, project/solution, local folder or create a new project. For this you would select "open a project or solution". The next window will then ask you to navigate to the requested folder. You must select the folder where the project was unzipped/desktop. You will see the name of the application followed by a ".sln" <-- (solution). Once it is double clicked Visual Studio will open the solution. When the solution is displayed, press (CTRL + F5), this will launch the application without the debugger. Else, you may launch it with the debugger.

APPLICATION extra
The application makes use of a .dll to calculate the books positioning. 
An NuGet Package: Control.Draggable was added version: 1.0.5049.269
GitHub HTTPS link: https://github.com/GabrielGrobb/PROG7312_Part1.git
SSH link: git@github.com:GabrielGrobb/PROG7312_Part1.git
GitHub CLI: gh repo clone GabrielGrobb/PROG7312_Part1
 
Possible errors
When attempting to run the application from the zipped folder. The possible error which you might encounter (Couldn't process file 'path' due to its being in the Internet or Restricted zone or having the mark of the web on the file). 

The following error is produced due to the “.resx” files. The application main folder contains sub folders. The following folders will have to be modified:

•	Forms
o	BookForm.resx
o	CallingNumbersForm.resx
o	Form1.resx
o	IdentifyAreasForm.resx
o	ResultsForm.resx
•	HelpForms
o	CNHelpForm.resx
o	HelpForm.resx
o	IDAreasHelpForm.resx
•	UserControls
o	BookUserControl.resx
o	CallingNumbersUserControl.resx
o	IdentifyAreasUserControl.resx
You will have to “right-click” each file, select “properties”, and at the bottom will be a checkbox with the title “Unblock”. 
