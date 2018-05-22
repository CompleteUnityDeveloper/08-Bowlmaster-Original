# Complete Unity Developer - Section 8 - Bowlmaster

This is the [Complete Unity Developer](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught over 360,336 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity Developer](http://gdev.tv/cudgithub)

## In This Section
### Introduction to Bowlmaster ###



### Section 8 Game Design Document ###

About the Game Design Doc
+ This part of the section notes is a simple reference for the important specifications of the game. 
+ This is just for reference, we'll refer to it as needed during the videos.

### Your Bowlmaster Assets ###

+ Your Bowlmaster assets attached.

### Section 8 Notes ###

+ What BowlMaster Teaches 
+ Manipulating a 3D world. 
+ Test driven development. 
+ Introducing Unity 5.

**Useful Links**
+ Section Links

### Installing Unity 5 ###

+ How to keep Unity 4.6.3 as well
+ Installing the latest Unity 5
+ A brief tour of what's different

### Creating 3D Cube Floor ###

+ Get used to 3D controls.
+ Create a bowling lane floor according to GDD.
+ Set your main camera to look down the lane.

### How To Install Blender ###

+ Blender is a 3D art program. 
+ We need it to import .blend files. 
+ It's amazingly powerful, but tricky to get started. 
+ You only need to install for this course, not use.
+ www.CompleteBlenderCreator.com to learn more.

**Useful Links**
+ [Complete Blender Creator Course](http://www.CompleteBlenderCreator.com)

### Import Pin From Blender ###

+ Import our bowling pin from Blender\* 
+ Learn about render and collider meshes. 
+ Create a pin prefab. 
+ Lay-out all 10 bowling pins on the floor.

**Useful Links**
+ \* Find out more at www.CompleteBlenderCreator.com 


### 3D Sphere As Bowling Ball ###

+ Create a 3D sphere of the right size. 
+ Apply a temporary texture so we can see it roll. 
+ Add a sphere collider. 
+ Add a Rigidbody (3D) and set properties. 
+ Make the ball roll down the lane.

**Useful Links**
+ [Floating Bowling Balls - YouTube](https://www.youtube.com/watch?v=FeKb_xfr608)

### Control Camera To Track Ball ###

+ Create CameraControl.cs for the Main Camera. 
+ Make the camera track the ball. 
+ Stop when it gets close to the headpin.

### 3D Collisions & Convex Meshes ###

+ Add Rigidbody to the pins. 
+ Adjust physics so that collisions work\* 
+ Create new, richer pin prefab. 

_\* We will make this more lifelike later_

### Top Camera Render Texture ###

+ Create a render texture\* ready for camera output. 
+ Position a top-down camera looking at pins. 
+ Create a user interface panel. 
+ Embed a “Raw Image” with this render texture. 

**Useful Links**
+ \* [Unity Manual - Render Texture](http://docs.unity3d.com/Manual/class-RenderTexture.html)


### Improve UI Scaling ###

+ Add new UI > Panel ready for swipe gesture. 
+ Set scaling & anchors for UI panels 
+ Make sure it scales well.

### Simple Touch Control System ###

+ Re-factor Ball.cs to create public Launch () 
+ Write DragLaunch.cs component for ball. 
+ Wire the UI Panel's events to DragLaunch.cs 
+ Test new drag control system.

### Adding Arrows To Nudge Ball ###

+ Add another UI panel at bottom of screen. 
+ Ensure this panel “occludes” the touch input. 
+ Add two arrows, for moving ball left and right. 
+ Write a simple method to allow this at start.

### Animation Sub-State Machines ###

+ Overview the pinsetter and our end-goal. 
+ Setup “swiper” bar to tidy & reset pins. 
+ Add a “Swipe” animation for pin clearing. 
+ About animation sub state-machines. 
+ Managing pin tidying and resetting.

### Working Around Nested Prefabs ###

+ Unity doesn't support “nested prefabs”. 
+ Care: the pins in Pins assembly are unlinked. 
+ Adding Pin.cs to the right place(s). 
+ About transform.rotation.eulerAngles. 
+ Writing code to detect if pins are standing

### Counting Upright Objects ###

+ About setting-up game object communication. 
+ Setup a simple UI Text display for pin count. 
+ Create a PinSetter box, and PinSetter.cs 
+ Continuously count standing pins. 
+ Only find standing pins after ball enters box.

### Keep Going! ###

Ben encourages you to keep going, even though the lectures are long, and the
subject matter is more complex.

### Detecting Pins Have Settled 1 ###

+ Use the PinSetter's trigger collider to detect ball. 
+ Only start counting upright pins when ball enters. 
+ Detect when pins have stopped wobbling. 
+ Update pin count display to green. 
+ Set lastStandingCount to -1 when settled.

### Detecting Pins Have Settled 2 ###



### Sub-states & Default States ###

+ Overview how Tidy & Reset will work. 
+ Modify the architecture of the game. 
+ Learn about sub-state machines. 
+ Learn about default transitions. 
+ Setup Tidy & Reset sub-states.

### Calling Animator Helper Scripts ###

+ Add temporary UI Buttons for Reset and Tidy. 
+ Write RaisePins() to lift all the standing pins up. 
+ Write LowerPins() to lower them down again. 
+ Test state machines work properly.

### Some Debugging Tips ###

+ A bit more about Transform.Translate(). 
+ Using the Step button to slow things down. 
+ The perils of moving static colliders. 
+ How default animation blends can cause issues. 
+ Warnings about moving motion clips around

### Common Physics Issues ###

+ A reminder about Fixed Timestep. 
+ About bounciness & default materials. 
+ Issues of scale & effect on Physics Settings. 
+ Stopping rigidbody's passing through each other.

### Tidying & Refactoring Code ###

+ About re-factoring your code. 
+ Single Responsibility Principle\* 
+ Wider framework of SOLID. 
  
**Useful Links**
+ \* [Single Responsibility Principle - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Single_responsibility_principle)

### How 10-Pin Bowling Scoring Works ###

+ Read how bowling scoring works\* 
+ Draw an Object Communication Diagram.

**Some useful links...**
+ \* [How to Keep Score in Bowling - YouTube](https://www.youtube.com/watch?v=aBe71sD8o8c)
+ \* [Ten Pin Bowling - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Ten-pin_bowling)


### Test Driven Development (TDD) ###

+ An overview of Test Driven Development (TDD). 
+ The Red > Green > Refactor loop. 
+ NEVER refactor with a failing test.

**Useful Links**
+ [Test Driven Development - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Test-driven_development)

### Install Unity Test Tools ###

+ What Unity Test Tools are\* 
+ How to ﬁnd and install them. 
+ Setting up your ﬁrst failing test.

**Useful Links**
+ \* [Unity Asset Store](https://www.assetstore.unity3d.com)

### Making Your First Test Pass ###

+ Setup our ScoreMaster.cs class. 
+ Write our ﬁrst few tests. 
+ Get the ﬁrst frame scoring properly.

### Red > Green > Refactor ###

+ Go through a few more TDD loops
+ Remember Red > Green > Refactor
+ Be strict with yourself, build the discipline
+ Save a version snapshot regularly
+ Have fun!

### Finishing Our Control Code ###

+ Finish the Control Code
+ Go through the Red > Green > Refactor loop strictly
+ Focus your failing tests on edge cases
+ Keep your ActionMaster.cs looking clean
+ Stop when you're confident it's done
+ Challenge the community to write a failing test!

### Failing Tests Challenge ###

+ Failing tests challenge

### Bug Reporting Cycle ###

+ A brief overview of a TDD bug reporting cycle
+ Creating relevant tests from user bug reports
+ Sticking to the TDD discipline

### Wire-Up ActionMaster.cs ###

+ Connect **PinSetter.cs** to **ActionMaster.cs**
+ Refactor **PinSetter.cs** to report pin fall
+ Connect **PinSetter.cs** to the animator
+ Remove the Tidy and Reset test buttons
+ Ensure our game controls it's self now

### Using OnTriggerExit() ###

+ Recap the problem with the current setup
+ Use **OnTriggerExit()** for objects leaving colliders
+ Refactor **PinSetters.cs** for the new paradigm.

### Creating A Testable Architecture ###

+ Taking the time to refactor
+ Being your own boss
+ Our current architecture
+ A target architecture
+ Keeping our tests in place

### Tidying Before Moving On ###

+ Removing unnecessary Unity Testing folders
+ Importing an animated gif texture
+ Quaternion.Euler() & Quaternion.Identy()
+ Using a boolean flag to prevent dragging
+ Using continuous dynamic collision detection

### Refactoring Code & Tests ###

+ Refactor your ActionMaster tests for new API
+ Refactor your code to single responsibility\*

**Useful Links**  
+ \* [Single Responsibility Principle - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Single_responsibility_principle)

### A Game Manager With State ###

+ Correcting a bug due to incorrect responsibility
+ Create **GameManager.cs** and **PinCounter.cs**
+ 'Weed' PinSetter.cs into these new classes
+ Call the static **ActionMaster.NextAction()**
+ Repeatably test everything still works ok

### An Epic TDD Challenge ###

+ An overview of the challenge (and delight) ahead
+ Find and move **ScoreMasterTest.cs** to Editor folder
+ Temporarily disable **ActionMasterTest.cs**
+ Write cumulative scorer in **ScoreMaster.cs**
+ Set THE challenge

### Realtime Bowling Scoring Solution ###

+ How we solved the scoring problem.
+ A reminder that it's the destination that counts.
+ How tests protect your refactoring.

**_“Make things as simple as possible, but not simpler”_** _Albert Einstein_

NOTE: I use a **for** loop in my solution, which you can read about in the
resources below. You can just as easily use a **while** loop.

**Useful Links**
+ [MSDN C# Reference - for loop](https://msdn.microsoft.com/en-us/library/ch45axte.aspx)

### Golden Copy Testing ###

+ What golden copies are.
+ Why they are useful for verification testing.
+ Using the **[Category (“Name”)]** test annotation.
+ Using binary search to find the failing test(s).
+ Commenting our code for future readability.

### An Array Of UI Text ###

+ Rearrange your UI to make space for scores.
+ Create your scoreboard.
+ Wire-up your scoreboard.

### Tracing Errors Using Console ###

+ Break your whole game!
+ Trace your bug via console.
+ Discuss handling undefined states.
+ Discuss isolating and fixing bugs.

### Try, Catch For Error Handling ###

+ How to decouple code with try{}, catch{}
+ Mainly used in file handling applications
+ Could be used in a team so one could move on
+ Isolating our **ScoreDisplay.cs** issues
+ Making our game fail gracefully

### Static Classes In C# ###

+ What it means to define a class as static.
+ The perils (and advantages) of statics.
+ Why we're using static here.
+ Refactoring a class to be static.
+ Learning to accept other people's code!

### Unit Testing MonoBehaviours ###

+ MonoBehaviour classes are hard to test\*
+ Code a testable static helper method.
+ Create our testing structure.
  
**Useful Links**
+ [Testing MonoBehaviours](https://blogs.unity3d.com/2014/06/03/unit-testing-part-2-unit-testing-monobehaviours/)

### Designing Your Own Tests ###

+ **public static string FormatRolls (List<int> rolls)**
+ Write your own tests as you go.
+ Stick to the red-green-refactor loop.
+ Aim for 20 lines or less of beautiful code.
+ Enjoy the process & share with [SPOILER].
  
**Useful Links**
+ Our Score Display Test 1 

### Final Fixes & Finishing Off ###

+ Stopping nudging ball off the floor
+ Make ball collisions detection continuous
+ Suggestions for improvement

### Bug Fixes & Upgrading Test Tools ###

+ Fix display of spare on last bowl.
+ Check that 0X displays properly.
+ Talk about upgrading Unity Test Tools.

### DOWNLOAD Section 8 Unity Project ###



### Section 8 Wrap Up ###
