<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="This_is_a_submition_for_Question_13_of_Weekly_Assignment_4_0"></a>This is a submition for Question 1.3 of Weekly Assignment 4.</h1>
<h2 class="code-line" data-line-start=1 data-line-end=2 ><a id="Submission_Patricipants_Rinat_Ozkesen_And_Daniel_Gimpelman_1"></a>Submission Patricipants: Rinat Ozkesen And Daniel Gimpelman</h2>
<p class="has-line-data" data-line-start="3" data-line-end="5">In Q1.3 we needed to add lives count to the player (a.k.a the spaceship), which means that each time the player touches the enemy spaceship his lives are decreased one by one until it reaches 0, when his life count reaches 0 the player dies.<br>
We decided to give the player 3 lives in the game, and each live is represented by a hearth sprite.</p>
<p class="has-line-data" data-line-start="6" data-line-end="7">Implementation:</p>
<ol>
<li class="has-line-data" data-line-start="7" data-line-end="8">When an enemy touches our spaceship the lives are decreased by 0, until 0 is reached.</li>
<li class="has-line-data" data-line-start="8" data-line-end="9">When 0 is reached the player spaceship is getting destroyed.</li>
<li class="has-line-data" data-line-start="9" data-line-end="12">We wrote the script below which implements section 1 and 2:<br>
<a href="https://github.com/GameDev2020/week_4/blob/main/1/3lives/Assets/DestroyWithLife.cs">https://github.com/GameDev2020/week_4/blob/main/1/3lives/Assets/DestroyWithLife.cs</a></li>
</ol>
<p class="has-line-data" data-line-start="12" data-line-end="15">The script technical implementation:<br>
The script gets as an input Array of objects, in our case the live hearts, and each time there is a collision with an enemy<br>
there is a destruction of a heart until there are no more hearts on scrren, when there is no hearts left, the player spaceship is getting destroyed.</p>