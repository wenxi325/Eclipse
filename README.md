# Eclipse
# Game Basic Information #

## Summary ##

**A paragraph-length pitch for your game.**

## Gameplay Explanation ##

**In this section, explain how the game should be played. Treat this as a manual within a game. It is encouraged to explain the button mappings and the most optimal gameplay strategy.**


**If you did work that should be factored in to your grade that does not fit easily into the proscribed roles, add it here! Please include links to resources and descriptions of game-related material that does not fit into roles here.**

# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

## User Interface

**Describe your user interface and how it relates to gameplay. This can be done via the template.**

## Movement/Physics - [Huilin Zhang]

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your movement scripts that do not use the physics system?**

### Player Movement
In the game, I use `PlayerController.cs` to implement movement for the main player. When the script is first called, I set the `target frame rate` to 60 since games are played best at 60 fps, in other words, a rate of 60 frames per seconds. 

Then in every updates, I created two variables to keep track of whether the player is moving horizontally or vertically or both. Then modify the current player positoin [by adding the movement axis multiply by `MoveSpeed` per frame.](https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/PlayerController.cs#L30-L35) That way, regardless of how player is moving, whether he is moving up-left, down-right, or anything else, the system is able to detect by using `Input.GetAxis`. Since I'm updating both horizontal and vertical axes each time, the system will be able to handle all movement situations.

### Camera Movement
There are two camera movement scripts, one is for small rooms or small scenes, another one is for the larger scene, in this case, the lobby. The `CameraFollow.cs` and `CameraFollowPlayer.cs` will be responsible for the camera movement.

The `CameraFollow.cs` doesn't have any update functions because it is responsible for small scenes that the player can view the entire scene/room without moving the main character around. As a result, I set the camera starting position to be the same as main character's current position and not updating the camera anymore. [https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/CameraFollow.cs#L27]

The `CameraFollowPlayer.cs` will have a slight difference with the previous camera script. I initialize the camera starting position to be same as the player's position. However, since the script is for larger scenes, where the player cannot view the complete scene and need to move around to see the complete room view, the script will have an update function that move as the player moves. In `Update()`, I first detect if the player has moved, then record the new position except the z-axis. [Lastly, use the function I learned in exercise 2 (`Vector3.lerp()`) to make camera moves along with the player.](https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/CameraFollowPlayer.cs#L35-L37) 

### Main Character Transport
In order to perform character transport properly, I decided to separate 6 different scenes, each scene represents one room and the main character will be able to transport via doors.

To achieve that goal, the door prefabs must have a collider and disable `isTrigger` so that the main character can collide with the door. 

## Animation and Visuals

**List your assets including their sources and licenses.**

**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**

## Input

**Describe the default input configuration.**

**Add an entry for each platform or input style your project supports.**

## Game Logic

**Document what game states and game data you managed and what design patterns you used to complete your task.**

# Sub-Roles

## Audio

**List your assets including their sources and licenses.**

**Describe the implementation of your audio system.**

**Document the sound style.** 

## Gameplay Testing

**Add a link to the full results of your gameplay tests.**

**Summarize the key findings from your gameplay tests.**

## Narrative Design

**Document how the narrative is present in the game via assets, gameplay systems, and gameplay.** 

## Press Kit and Trailer

**Include links to your presskit materials and trailer.**

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**



## Game Feel

**Document what you added to and how you tweaked your game to improve its game feel.**