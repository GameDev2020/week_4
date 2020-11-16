<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="This_is_a_submition_for_Question_15_of_Weekly_Assignment_4_0"></a>This is a submition for Question 1.5 of Weekly Assignment 4.</h1>
<h2 class="code-line" data-line-start=1 data-line-end=2 ><a id="Submission_Patricipants_Rinat_Ozkesen_And_Daniel_Gimpelman_1"></a>Submission Patricipants: Rinat Ozkesen And Daniel Gimpelman</h2>
<p class="has-line-data" data-line-start="3" data-line-end="5">In this question we needed to implememt the following:<br>
There are two types of enemies:</p>
<ol>
<li class="has-line-data" data-line-start="5" data-line-end="6">Slow and easier enemy which destruction rewards the player with one point.</li>
<li class="has-line-data" data-line-start="6" data-line-end="8">Fast and harder enemy which destruction rewards the player with Three points.</li>
</ol>
<p class="has-line-data" data-line-start="8" data-line-end="10">To implement this idea we decided to use tags for each group of enemy (a slow one and a fast one per say) and created a new<br>
game object corresponding to each tag.</p>
<p class="has-line-data" data-line-start="11" data-line-end="12">The implementation is as following:</p>
<ol>
<li class="has-line-data" data-line-start="12" data-line-end="16">Changes to DestroyOnTrigger2D.cs script as following:<br>
Added a distinction between a fast and a slow enemy destruction, as well as implementing destruction for the newely created tag “Fast enemy”.<br>
Source code available directly at:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/1/FastSlowEnemy/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs">https://github.com/GameDev2020/week_4/blob/main/1/FastSlowEnemy/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs</a></li>
<li class="has-line-data" data-line-start="16" data-line-end="20">Changes to ScoreAdder.cs script as following:<br>
The function which corresponding to the score count is now able to distinct between the two types of enemies (Fast and slow one) and thus update the score correctly.<br>
Source code available directly at:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/1/FastSlowEnemy/Assets/Scripts/3-collisions/ScoreAdder.cs">https://github.com/GameDev2020/week_4/blob/main/1/FastSlowEnemy/Assets/Scripts/3-collisions/ScoreAdder.cs</a></li>
</ol>
