<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="This_is_a_submition_for_Question_2_of_Weekly_Assignment_4_0"></a>This is a submition for Question 2 of Weekly Assignment 4.</h1>
<h2 class="code-line" data-line-start=1 data-line-end=2 ><a id="Submission_Patricipants_Rinat_Ozkesen_And_Daniel_Gimpelman_1"></a>Submission Patricipants: Rinat Ozkesen And Daniel Gimpelman</h2>
<p class="has-line-data" data-line-start="3" data-line-end="4">In This project there are 3 scenes ordered in the following way:</p>
<ol>
<li class="has-line-data" data-line-start="4" data-line-end="6">Flat world with visible boundries:<br>
We defined 4 objects representing the camera boundries with the following components for the camera and the player:</li>
</ol>
<ul>
<li class="has-line-data" data-line-start="6" data-line-end="7">BoxCollider2d</li>
<li class="has-line-data" data-line-start="7" data-line-end="8">Rigidbody2d</li>
</ul>
<ol start="2">
<li class="has-line-data" data-line-start="8" data-line-end="15">
<p class="has-line-data" data-line-start="8" data-line-end="14">Flat World with invisible boundries:<br>
In this question we used camera boundries to limit the movement of the player, in other words if the player touches the boundries he cannot move further in the axis, we used the following script:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/limitworld_que2_2.cs">https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/limitworld_que2_2.cs</a><br>
What was done with this script is converting the space boundries to the camera boundries, which makes the boundries finite to the camera dimentions.<br>
In addition the following script was used to destroy the player and the laser as requested:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/que_2_2_LimitDestroy.cs">https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/que_2_2_LimitDestroy.cs</a></p>
</li>
<li class="has-line-data" data-line-start="15" data-line-end="19">
<p class="has-line-data" data-line-start="15" data-line-end="19">Circular world with boundries:<br>
We used the following script:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/roundWorld.cs">https://github.com/GameDev2020/week_4/blob/main/2/que2/Assets/roundWorld.cs</a><br>
This script converts again space boundries to the camera boundries, which makes the boundries finite to the camera dimentions, only that this time in order for the world to be circular the following was done:</p>
</li>
</ol>
<ul>
<li class="has-line-data" data-line-start="19" data-line-end="20">if the player collides with the right border he would transfoporm to the left side, and vise versa.</li>
<li class="has-line-data" data-line-start="20" data-line-end="21">If the player collides with the top of the camera he would transform to the bottom of the camera, and vise versa.</li>
</ul>
