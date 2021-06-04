# CelebrityNews-App
Created using Xamarian forms a framework of .NET

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
