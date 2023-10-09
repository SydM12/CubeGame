# CubeGame
This is a 3-level obstacle rush game built in Unity via C#.

all the .cs files have the C# code used in the project.
These are the C# scripts that set the logic rules and physics of the game using C#.

Credits.cs: This script will terminate the game after it is over.
EndTrigger.cs: This script will use a method as a trigger method from unity to the end level.
FollowPlayer.cs: This script will have the camera follow the player using a vector and its offset.
GameManager.cs: This script will manage all stages of the game relevant to ending a level and starting a new level.
LevelComplete.cs: This script will tell the scene manager of Unity to finish this level.
menu.cs: loads the menu at the start of the game.
PlayerCollision.cs: Restarts a level if the red cube hits any other object.
PlayerMovement.cs: This script dictates the movement of the player by reading A and D as inputs(if the y position of the player is negative they have fallen and the game is over.
Score. cs: Keeps the distance traveled as a score and displays it in the game.

The zip folders have the deployable game ready to execute: "MacandCube.zip.app" is for Mac OS users and "x86 0.2 - Copy.zip" is for 64-bit Windows OS computers.


