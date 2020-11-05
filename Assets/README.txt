        
        Constraints List:
 ***************************************
- EVERY SCRIPT you add must have the same unique namespace:
	
	namespace MyTeam
	{
		public class MyClass : monobehavior
		{
		// Your code here //

		}
	}

	- ^ If you don't do this, there may be naming conflicts with other team's projects
	- Give the folder you submit this same name, for the same reason
 *****************************************
 - Keep sounds to the Minigame scriptable object
    - This is so your sound will be faded out on transition rather than cut off or continue playing
    
 ***************************************** 
- Stick to WASD/arrow keys and space for your games controls. 
    - You can technically still call Input.GetKeyDown, but this may confuse the player. Keeping the controls simple makes the snappy-ness of these games possible
    
    
        Tips List:
 *****************************************
 - The name of your scene is made into text that flashes before your game starts
    - Use this text to give some direction to the player
    
 *****************************************
 - On the minigame manager object in the inspector, theres a bool called "debug game only". Make this true if you want to test the game alone
 
 *****************************************
 - Music Making Guidelines: 
    - 141 BPM
    - Short games are 2 measures (~3.4 seconds)
    - Long games are 4 measure (~6.8 seconds)




