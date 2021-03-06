# TrackFitt
TrackkFitt is a Macronutrient tracking application That calculates your caloric needs and keeps a diary for you to monitor daily food intake. 

# Table of Contents

* [User Stories](https://github.com/miseryprevails/TrackFittUpdated#TrackFitt#user-stories)
* [Entity Relationship Diagram](https://github.com/miseryprevails/TrackFittUpdated#entity-relationship-diagram)
* [UML Diagram](https://github.com/miseryprevails/TrackFittUpdated#uml-diagram)
* [Wireframe](https://github.com/miseryprevails/TrackFittUpdated#wireframe)
* [Requirements & Test Results](https://github.com/miseryprevails/TrackFittUpdated#requirementstest-result)
* [Prototype](https://github.com/miseryprevails/TrackFittUpdated#prototype)
* [Application Walkthrough](https://github.com/miseryprevails/TrackFittUpdated/blob/master/README.md#application-walkthrough)
* [Conclusion](https://github.com/miseryprevails/TrackFittUpdated/blob/master/README.md#conclusion)


### User Stories
As a Fitness Marketing Company 
I need/want a functional system that creates a user profile, and a Macronutrient tracking log capability linked to that profile 
So that users can track and edit their daily food intakes tailored to their specific goals.

#### Use Cases

1.	The System shall correctly take in users’ login and password credentials.
1.1	The system shall present a GUI for the login credentials to log in users.

1.2 The system shall provide a username and password bar followed by a sign in button to connect to online database to store user’s profile. 

1.3The system shall save the users login data to a secured database.

2.	The system shall build a default profile at time of signup.

2.1	the system shall display a default profile at time of login.

2.2	the systems shall allocate memory for Profile stats that the user can add as needed.

2.3	The system shall provide a GUI with a name, Age, Gender, Height, Weight, Goal for users to input their personal goal information.

2.4	The system shall store information in a database.

3.	The system shall calculate the users basal metabolic rate using a calculator function.
3.1 The system shall take the users age height and weight profile information and use an algorithm (Harris benedict equation to calculate) to calculate the user’s Basic metabolic rate and store it to their profile stats. 
				
4.	The system shall provide GUI with search bar connected to database for users to select and store foods into their profile as needed. 

4.1	The system shall display a GUI for users to search and easily navigate through data(Food) to store into their daily table, as necessary.

5.	The system shall provide users with an editing function to change serving sizes of selected foods.
5.1 The system shall provide a function to click on the food name, to bring up the portion size and change as needed.

6.	The systems shall have set time to reset users daily table data each day.

6.1	The system shall reset time at 12:00 AM and run till 11:59 AM to represent a full day of data.

7.	The system shall store previous data for users to access older food logs. 
7.1 The system shall store older Data and data changes each day(Temporal Tables?) in memory for users to access older daily food logs .



## Entity Relationship Diagram
![Entity Realtionship](https://github.com/miseryprevails/TrackFittUpdated/blob/master/EntityRelationship.PNG)


## UML Diagram
![UML Diagram](https://github.com/miseryprevails/TrackFittUpdated/blob/master/UML%20diagram.PNG)



## WireFrame
![Wireframe Layout](https://github.com/miseryprevails/TrackFittUpdated/blob/master/WireFrame.jpg)
First GUI represents the the start page and login screen.

Next two boxes on first page are userid and password, followed by login, or cancel.

Next box(to the right) is a basic profile with the option to add image in the top left corner. The box to the right will display the users stats and the box at the bottom is navigation away from the profile to other GUI in the application.

The bottom box is a serach GUI for foods, the text box is where food names will be typed by user, followed by a search button 
below. to the right will display results where user can select the foods they need.

## Requirements/Test Result

| ReqID | Requirement | Test Procedure | Test Result |
|:--|:--|:--:|:--|
| 1. | the system shall correctly take users login and password credentials | User Login | Pass |
| 1.1| The system shall present a GUI for the login credentials to log in users. | User Login | Pass|
| 1.2 | The system shall provide a username and password bar followed by a sign in button to connect to online database to store user’s profile.  | Identity | Pass |
| 1.3 | The system shall save the users login data to a secured database. | Identity | Pass |
| 2 | the system shall display a default profile at time of login.| Profile | Not Implemented |
| 2.1 | the systems shall allocate memory for Profile stats that the user can add as needed.| Profile | Pass |
| 2.2 | The system shall provide a GUI with a name, Age, Gender, Height, Weight, Goal for users to input their personal goal information | Profile | Not Implemented |
| 2.3 | The system shall store information in a database.| Profile Table | Pass |
| 3. | The system shall calculate the users basal metabolic rate using a calculator function. | Algorithm | Not Implemented |
| 3.1 | The system shall take the users age height and weight profile information and use an algorithm (Harris benedict equation) to calculate the user’s Basic metabolic rate and store it to their profile stats.  | Algorithm | Not Implemented |
| 3.2 | The system shall provide GUI with search bar connected to database for users to select and store foods into their profile as needed. | Database Access | Pass |
| 3.3 | The system shall display a GUI for users to search and easily navigate through data(Food) to store into their daily table, as necessary. | Website Layout | Pass |
| 4. | The system shall provide users with an editing function to change serving sizes of selected foods.| Create A Food | Not Implemented |
| 4.1 | The system shall provide a function to click on the food name, to bring up the portion size and change as needed. | Search For Food | Not Implemented |
| 5. | The systems shall have set time to reset users daily table data each day. | Data Reset | Not Implemented |
| 5.1 | The system shall reset time at 12:00 AM and run till 11:59 AM to represent a full day of data. | Data Reset | Not Implemented |
| 6. | The system shall store previous data for users to access older food logs. | Memory Data | Not Implemented |
| 6.1 | The system shall store older Data and data changes each day(Temporal Tables?) in memory for users to access older daily food logs | Data Storage | Not Implemented |

## Test Metrics

8 out of 18 requirements are passing which is 44 %. Majority of non passing requirements are due to not implementing them inside the project yet. 


## Prototype
![Log In Screen](https://github.com/miseryprevails/TrackFittUpdated/blob/master/Prototype%20HTML%20%26%20Pictures/LogInScreen.jpg)

This the Log In Screen. Here you have a username and password box to enter credentials. you also have the forgot password option to retrieve password, and below you can click new signup to create your new profile below.



![Profile Page](https://github.com/miseryprevails/TrackFittUpdated/blob/master/Prototype%20HTML%20%26%20Pictures/ProfileScreen.jpg)

Here is the profile screen once you have logged in. you have your feed which shows you food logging activity. you have the option to add a profile bio, and below that you can set a status (Had a good workout today!) you can navigate to the tabs to make a post, reply to a connection, or view your total connections.

![Calorie Calculator](https://github.com/miseryprevails/TrackFittUpdated/blob/master/Prototype%20HTML%20%26%20Pictures/CalorieCalculator.PNG)

Here is the page where based on your stats put in, you will get a number back which will determine your total calorie intake needs based on goals selected. you can also sumbit your day activity at the bottom in the day activity bar.

## Application Walkthrough
![Login](https://github.com/miseryprevails/TrackFittUpdated/blob/master/TRACKFITT%20PHOTOS/LOGIN.PNG)

Here is the Login Screen using Microsoft Identity. I applied a bootstrap card because the font was hard to read. 

![Home Display](https://github.com/miseryprevails/TrackFittUpdated/blob/master/TRACKFITT%20PHOTOS/HomeScreenDisplay.PNG)
Here is the home screen display where you have multiple tabs to choose from. My Activity is this cuurent page, Profile will take you to a profile page,
Calorie Calculator was not implemented, however it was planned to take you to a page to put in your height, weight, age, gender, activity level to calculate yourcaloric intake. Add a Food allows you to add a new food to the table. this functionality still needs to be tied into the master food database so it adds it with the rest of the preloaded foods. Search for food tab will take you to a page where you can search the master food table for pre loaded foods and add them to your diary. this page is very slow to load and still has some bugs. 

![Profile](https://github.com/miseryprevails/TrackFittUpdated/blob/master/TRACKFITT%20PHOTOS/Profile.PNG)

![Create Food](https://github.com/miseryprevails/TrackFittUpdated/blob/master/TRACKFITT%20PHOTOS/CreateYourOwnFood.PNG)

![Search Food](https://github.com/miseryprevails/TrackFittUpdated/blob/master/TRACKFITT%20PHOTOS/SearchThePreLoadedFoodTable.PNG)


## Conclusion

### What was done right
I think the foundation of this application is heading in the right direction. alot of the pages are still CRUD but as I continue to learn I will add the missing pieces of functionality. 

### What was done wrong
Going into this project I had a vision in mind that was comparible to an already existing application named MyFitnessPal, which is widely used today. I wanted to create a product that resembled it in a way with my own spin on things, But im sure that creating MyFitnessPal was a group effort and I think I tried to add to much functionality to my application and as a result, it is missing alot of the cruical pieces to function as it should. 

### Where I was lucky
After having a meltdown with GitHub Desktop, I lost my whole repository and had to rebuild it, and my project would not load. I was able to find out that the cause was because the project was moved out of a previous folder and rebuilt a new updated repository and reuploaded the project and was smooth sailing from there. I was scared that I lost my project that day. 

### Changes I would have made
I would have cut alot of functionality away. It would of been an application with 2 options. A calculator to calculate your caloric intake, and then a diary like page where you add all your food in yourself. I would of been left with more time to really create an amazing application.



