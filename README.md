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

## Movement/Physics - [Huilin Zhang]

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your movement scripts that do not use the physics system?**

### Player Movement
In the game, I use `PlayerController.cs` to implement movement for the main player. When the script is first called, I set the `target frame rate` to 60 since games are played best at 60 fps, in other words, a rate of 60 frames per seconds. 

Then in every updates, I created two variables to keep track of whether the player is moving horizontally or vertically or both. Then modify the current player positoin [by adding the movement axis multiply by `MoveSpeed` per frame.](https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/PlayerController.cs#L30-L35) That way, regardless of how player is moving, whether he is moving up-left, down-right, or anything else, the system is able to detect by using `Input.GetAxis`. Since I'm updating both horizontal and vertical axes each time, the system will be able to handle all movement situations.

### Camera Movement
There are two camera movement scripts, one is for small rooms or small scenes, another one is for the larger scene, in this case, the lobby. The `CameraFollow.cs` and `CameraFollowPlayer.cs` will be responsible for the camera movement.

The `CameraFollow.cs` doesn't have any update functions because it is responsible for small scenes that the player can view the entire scene/room without moving the main character around. As a result, I set the camera starting position to be the same as main character's current position and not updating the camera anymore. https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/CameraFollow.cs#L27

The `CameraFollowPlayer.cs` will have a slight difference with the previous camera script. I initialize the camera starting position to be same as the player's position. However, since the script is for larger scenes, where the player cannot view the complete scene and need to move around to see the complete room view, the script will have an update function that move as the player moves. In `Update()`, I first detect if the player has moved, then record the new position except the z-axis. Lastly, use the function I learned in exercise 2 (`Vector3.lerp()`) to make camera moves along with the player. https://github.com/wenxi325/Eclipse/blob/af88556bd83cd9411c60bf9d565730843c7eec64/Assets/Scripts/CameraFollowPlayer.cs#L35-L37

### Main Character Transport
###### **Overall**
In order to perform character transport properly, I decided to separate 6 different scenes, each scene represents one room and the main character will be able to transport via doors.

To achieve that goal, the door prefabs must have a collider and disable *isTrigger* so that the main character can collide with the door. In this case, `Box Collider 2D` will be sufficient since the door is rectangle shape. Moreover, I created 13 more tags so that I can keep track of which door the player has collided with. Below is an example of doors that can transport player back to the dorm room:

![Door exmaple](./images/door_transport_example.png)

As you can see, I set the box collider at the top of the door instead of fill out the entire door. That is because if I set collider's shape to be the same as the door, the player will immedately be tranported when he just touched door's bottom line. However, the player will be transported only when he steps into the door. Hence, I leave some spaces for player to move around and transport him when he really tries to enter the door.

###### **Implementation (Script)**
The `DoorController.cs` script in the `Doors` folder manages the door transportations. Inside the script, depending on the tag that current door has, will switch to different scenes by modifying the build scene index. I have created 6 scenes and added them to the build settings in order when I created them. Below is a screenshot of the build settings in our game:
![Build setting](./images/build_setting.png)

Here is an example of how my script will work: Let's say the player enters a door that has a tag "Lobby_up_right", indicates that he is trying to enter the up-right door in the lobby. In our settings, the up-right lobby door is connected to the data room. The `Lobby` scene is at *level 1* while the `DataRoom` scene is at *level 3*, so I will add 2 to the current `buildIndex` so that it gets to the `DataRoom` scene.
https://github.com/wenxi325/Eclipse/blob/a9165cc5ffed2a679cfe4389daff6c5e2e0f9dd0/Assets/Scripts/Doors/DoorController.cs#L75-L77
On the other hand, if the player is trying to go back to the `Lobby` from `DataRoom`, subtract 2 from the `buildIndex` to reach *level 1*.https://github.com/wenxi325/Eclipse/blob/a9165cc5ffed2a679cfe4389daff6c5e2e0f9dd0/Assets/Scripts/Doors/DoorController.cs#L84-L86

###### **Exit Button**
There is an exit button at the upper right corner which will be back to the very beginning entering scene. For simplicity, I didn't create a separate script to manage the exit button. Instead, I assign all the exit buttons in all scenes with a *exit_btn* tag. Inside the function `OnMouseDown()`, if the *exit_btn* tag is clicked, load the `EnteringGame` scene immediately no matter where the player is currently at.https://github.com/wenxi325/Eclipse/blob/a9165cc5ffed2a679cfe4389daff6c5e2e0f9dd0/Assets/Scripts/Doors/DoorController.cs#L51-L53

Similar to the doors, the exit buttons also have a `Box Collider 2D` but enable the *isTrigger* option. Here is an example of the exit button:
![Exit button](./images/exit_btn_example.png)


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



## Game Feel - [Huilin Zhang]

### Scenes Loading
###### **Small Scenes**
After receving all the artworks in *.psd* form, I load the all the items into Unity and ajust the scale of all the scenes until it looks comfortable to play. In other words, the small rooms can be fit into camera view and people can see the entire room settings without moving around. As a result, for small rooms, I find the best scale which is `563.1652`. Since the scenes are scaled up, the main character also needs to scale up. 
![Small scene](./images/small_scene_example.png)

###### **Large Scene(Lobby)**
The lobby scene will not need that much scale up, instead, it only needs to scale up by `123.2818`. I got this number by comparing the player's size and the robot size in the lobby scene. The player is a little shorter than the robot:
![Large scene](./images/large_scene_example.png)

###### **Modify Colliders**
**Box Collider 2D**

Visually, it will look awkward if I don't modify all the collider shapes. For example, when the character walks around the dormant bin, he should be able to cross the dormant bin once his legs are below the bottom line of the dormant bin. 
![Dormant bin](./images/dormant_bin.png)

The red rectangle represents the modified collider shape, which cuts almost half of the dormant bin's height. In contrast, if the red rectangle has the same height as the dormant bin, the character will not be able to cross the dormant bins and will be weird visually. Similar to across the robots, since the character's layer order is higher than robots, the character will cover robot's part as he walk across them. As a result, adding a box collider to the robot that has a shape of robot's head will look reasonable.
![Robot box](./images/robot_box.png)

Box colliders can also be used to prevent the main character walk upon walls. In most of the rooms, I add a bunch box colliders on the wall so that the character cannot walk on the walls. The height of the box will be half of wall's height so that makes the character look like he is walking along the wall.
![Wall box](./images/wall_box.png)

Another example of using box collider is all the control panels. Since the game is in 2D but all drawings are almost 3D. To make it visually reasonable, I modify the box collider as shown below:
![Control1 box](./images/control1_box.png)
![Control2 box](./images/control2_box.png)

I have made two different visualizations of the two types of control panels. The first one's order layer is higher than the character so he can only walk at the back of the control panel. The second one's order layer is lower so the character can walk in front of it.

**Edge Collider 2D**

Without setting edges of the scenes, the character can go off the scene and lost in the entire space. As a result, *Edge Collider* plays a significant role in restricting the player to stay in place. In every scene excluding the `EnteringGame` scene, I create boundaries around the room by using *Edge Collider*. Below is an example of combining *Box Collider*(in red) and *Edge Collider*(in pink).
![Edge example](./images/edge_example.png)

**Polygon Collider 2D**

The *Polygon Collider* is suitable for prefabs that are not in a regular shape. In this case, a semi-circle table is neither a rectangle nor a capsule. At this situation, a polygon collider will perfectly resolve the problem. I use 10 points and connect them together to trace a similar shape of semi-circle table. After applying the 2D visualization as mentioned previously, I need to leave some spaces for the character to walk along with the table. Below is the polygon collider I created for the table:
![Lobby desk](./images/lobby_desk_example.png)