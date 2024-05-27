### Game developer learning path


Fourth project following the course: https://www.youtube.com/watch?v=VHLz-UHErnA&list=PLNEAWvYbJJ9mkqg3luCyqlBvT8IWVkDfz&index=1

_Resume_: The game is about HelixJump game.

__Project type__: 3D 

__Notes__:
 - In this project I see for the first time an script that does not inherit from MonoBehavior
 - A special script was created to create dynamically the stages in the helix

# Key things learned
 - how to add packages
  - it was added a package for a circular section to build the complete helix
 - how to pin the objetive of the camara to a game object.
 - rotate an object using the mouse control 
 - how to store player status and start new game with the last status
 - If "Is Trigger" option is true in a box collider, then it will ignore the physics
  - this is useful to allow the ball to traspass the boxcollider in each level
 - How to change the color by code
 - Get the collisioner object asking directly to collision.transform.GetComponent<expectedType>
  - if its null means the collisioner object was diferent from the expected type
 - how to add helix levels by code
 - change the rendering path to Deferred to improve the lightning and shadows 
 - using the annotation HideInInspector a property is not visible in Unity inspector
 - how to add animation, study case, message "+1" when a point is made

# What to add
 - 
