[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects?
- Player
- Plants 
- UI: the seeds planted shows how many seeds have been planted while the seeds remaining shows how many more times the player can plant seeds

What attributes and actions do these objects have?
- Player
  - Player can move around with WASD and plant seeds via the space bar. The plants show up at the player's location and change the UI. It checks how many seeds the player has left. 
  - Attributes: bunny sprite
- Plants
  - The plants stay in the place the player was when they are planted
  - Attributes: plant sprite
- UI
  - Changes value (seeds planted goes up and seeds remaining goes down) when the player plants a seed
  - Attributes: text 

How do these objects act on or affect each other?
- Player
  - Player’s location when they plant a seed is where the seed will stay
  - When the player plants a seed, the UI will respond accordingly
- Plants
  - When the player plants a seed, they spawn a plant prefab, which stays in place
- UI
  - When the player plants a seed, the seeds planted UI goes up by one while the seeds remaining UI goes down by one

## Devlog
In my breakdown, I listed the various game objects, their attributes, and what they can do. This helped me with making my code for this assignment. The first action I worked on was player movement, as it was the easiest to do. I accomplished this by detecting WASD inputs in the update section of the player script, making each key go in a different direction by using _playerTransform. 

Next, I worked on the having the player plant the plant. I first made the plant as a game object, then moved it to the prefab files. After, I deleted the original object and the plant could be used for the player to plant and I added the prefab to the player script. To first plant, I made an if statement to detect the space bar being pressed. Then, I used the instantiate function in the PlantSeed function. Once the plant would spawn with the instantiate function, I added more parameters (the player's position and rotation from the transform component) to make the plant spawn where the player was at the time they pressed space. Once I had the planting meachnic down, I added an additional if statement nested in the input detection statement to check how many seed the player had, and if it was zero, the player wouldn't be able to plant anymore. 

For the UI, I first changed the base value of the Planted text and the remaining text to 0 and 5 respectively. Then, within the space bar detection statement, I subtracted one from the seeds remaining and added one to the seeds planted. I knew that each seed planted would change the UI, so I changed the values in the space bar statement. Then, I edited the UpdateSeeds function to change the current text_SeedsPlantedNum and the current text_SeedsRemainingNum to reflect the values after subtracting and adding in the space bar statement. At first, Untiy was giving me an error about converting int to string, so I added the ToString function to the integers to make sure they could show up on screen. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for connecting your break-down to your code. I think you could have been a little more thorough in ensuring you continued to mention the break-down plans throughout your Devlog (e.g., by continuing to reference the objects, attributes, or actions from the break-down), but you did a good job describing what was happening in your code. 

Overall, I'm glad you were able to get this project done despite not having coded in a long time!

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
