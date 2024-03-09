# 05-Space-SHMUP - Ayub
The updates that I made to the game are only to the aesthetics. I added individual materials for the hero and each of the 5 guns that it has along with an upgraded background. 
The gun materials change depending on the type of ammo it is shooting to show a visual indicator when not shooting the weapon.

# 05-Space-SHMUP - Damian
I added an in-game timer that starts when the scene is loaded. Every 30 seconds, the enemy_0 prefab is modified to add +5 speed and +10 health. This effects all enemies and 
makes the game more challenging over time.

# 05-Space-SHMUP - Charlie
I created a 5th and 6th enemy type. Enemy 5 works similarly to enemy 4, but is an easier variant that randomly zig-zags around. Enemy 6 is a ship that moves back and forth 
at the lop of the screen, launching smaller ships every few seconds.

# 05-Space-SHMUP - Max
I changed the workings of how the guns work, When you get a pickup of a different type, instead of it clearing all pickups of the previous kind, it adds the new pickup to the 
list of weapons, You can pickup items of the same kind until all weapons are the same.

# 05-Space-SHMUP - Maria
I changed the colors of the enemies so each are color-coded and updated the shield color. I created a title screen with a custom button and script that takes you to the game scene. Afterwards, I duplicated the title screen to create the end screen and altered the buttons. At this point, I edited the hero script, adding scene manager and had the Game Over screen's button send the player back to the game scene.

We were able to merge all five of our branches. Everything went very smoothly and only needed minor bug fixing!

We modified the values of the vanilla guns.
Blaster - .5 dmg/.1 delay/50 velocity = 5 dmg per second
Spread - 4 dmg/.5 delay/25 velocity = 8 * 3 dmg per second but shots are harder to hit