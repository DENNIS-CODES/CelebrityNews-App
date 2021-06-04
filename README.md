# CelebrityNews-App
Created using Xamarian forms the popular mobile development framework that extends the .NET developer platform with tools and libraries for building mobile apps.

# 1.
The application contains a home screen with the title CelebJITSU Home, as 
illustrated below. It display a menu of three items, centered in the middle of the screen: 
Birthday calendar, Celebrities, and Celebrity categories, with descriptions provided 
underneath, as shown on the screenshot

# HOMESCREEN SCREENSHORT
![image](https://user-images.githubusercontent.com/65861136/120707091-91939580-c4c2-11eb-9b33-fa9864657ef2.png)

# 2.
By selecting the Celebrities item from the menu, the user shall be able to see the list of 
all partnering celebrities with their pictures, as illustrated below on the left.
1 The screen 
shall be titled Favourite Celebrities. It shall let the user indicate favourite celebrities and 
navigate back to the home screen. The user’s choice shall persist and be displayed when 
the user revisits this screen. Hint: the list functionality can be implemented in 
Xamarin.Forms by means of a ListView with an ItemTemplate that contains a ViewCell.
Further, the source of an Image view can be specified as an URL

 Favourite Celebrities | Celebrity Details
:-------------------------:|:-------------------------:
![image](https://user-images.githubusercontent.com/65861136/120792820-c34a4200-c53e-11eb-99cf-bcf86a4de2ab.png) | ![image](https://user-images.githubusercontent.com/65861136/120792941-ec6ad280-c53e-11eb-9078-e32ef7e20dd0.png)

# 3.
Further, by tapping on a celebrity in the list, the user shall be able to see their picture and 
basic information about them displayed on a separate screen, as shown in the 
screenshot above on the right. The screen shall have the celebrity’s name as its title, and 
it shall let the user navigate back to the list of celebrities. The picture shall be horizontally 
centred and be 360 pixels in height. The celebrity’s birthday shall be displayed under the 
picture in the format shown on the screenshot. Basic information shall be displayed 
underneath the birthday in the colour CadetBlue

# 4.
Selecting the Celebrity categories item from the menu on the home screen shall offer 
the user an opportunity to select categories of celebrities for displaying in the birthday 
calendar, as illustrated below. The screen shall be titled Celebrity Categories and it shall 
let the user navigate back to the home screen. The user’s choice shall persist and be 
displayed when the user revisits this screen. Hint: the screen functionality can be 
implemented in Xamarin.Forms by means of a ListView with an ItemTemplate that 
contains a SwitchCell.

![image](https://user-images.githubusercontent.com/65861136/120795448-2be6ee00-c542-11eb-83b5-22d6a2b4082b.png)

# 5.
Selecting the Birthday calendar item from the menu on the home screen shall display a
calendar in the month view as illustrated below, and highlight the current date (left), and 
the dates on which favourite celebrities of selected categories have birthdays (right).

Birthday calendar | Birthday calendar
:-------------------------:|:-------------------------:
![image](https://user-images.githubusercontent.com/65861136/120795899-c5160480-c542-11eb-893e-774fceb021d2.png) | ![image](https://user-images.githubusercontent.com/65861136/120795972-da8b2e80-c542-11eb-9d26-7e9e29788a90.png)

# 6.
The screen shall be titled Birthday Calendar. It shall initially display the current month, 
which is to be indicated in the top-left corner of the screen, as illustrated in the 
screenshots. It shall further offer the user a possibility of moving back and forth in time by 
pressing the respective buttons at the bottom of the screen. Weeks in the calendar shall 
commence on Monday. Dates of the preceding and the following month should not be 
displayed. It is essential that birthdays repeat themselves year on year. The screen shall 
also let the user navigate back to the home screen. Hints: the calendar grid functionality 
can be implemented in Xamarin.Forms by means of a CollectionView with an 
ItemTemplate that contains a Label and, optionally, other views. The property ItemsLayout
of the CollectionView shall be set to "VerticalGrid, 7" in order to achieve the desired 7-
column layout. Highlighting of dates in the calendar may deviate from the examples given 
here in terms of colour and shape. Further, you may find the following methods and 
properties of the DateTime class in C# useful: DaysInMonth(), Today, and DayOfWeek.

# 7.
Clicking on a date that indicates a celebrities’ birthday shall reveal the celebrity’s name
underneath the calendar, or the list of names if there are several celebrities having their 
birthday on that date. Further, by tapping on a celebrity’s name, the user shall be able to 
see their picture and basic information about them displayed on a separate screen. 
That screen shall have the celebrity’s name as its title, and it shall let the user navigate 
back to the calendar. The screenshots below illustrate this. Clicking on any date that is 
not a birthday shall remove celebrity names from the screen. Also moving from month to 
another shall remove any celebrity names from the screen. Hint: the list functionality can 
be implemented in Xamarin.Forms by means of a ListView.

Birthday Calendar | Celebrity Details
:-------------------------:|:-------------------------:
![image](https://user-images.githubusercontent.com/65861136/120796376-6d2bcd80-c543-11eb-8d0c-0fe111521a27.png) | ![image](https://user-images.githubusercontent.com/65861136/120796462-82a0f780-c543-11eb-8c81-f49678ef3a3a.png)

# 8.
On start of the app, it shall receive the celebrities’ data as a character string in the JSON 
format. These data may include any number of celebrities.For simplicity of developing and testing 
the app, the entire contents of the text file can be assigned to a local variable of type 
‘string’ in the body of the method OnStart() of the App class. The value of that variable 
can then be converted to an array of objects that will represent the respective celebrities.
# 9.
The app shall persist the user’s preferences in terms of favourite celebrities and celebrity 
categories. These preferences shall be saved when the app closes or is moved into the 
background; and they shall be restored when the app is starting or resuming. As there are 
no preferences to be restored on the first start, the app shall assume that all celebrity 
categories are selected but none of the celebrities are selected as favourite
