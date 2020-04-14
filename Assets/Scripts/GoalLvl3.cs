//Add the Unity things at the top.

//Change file type if needed.

//Attach this script to the fridge AT THE END OF LEVEL 3

//You'll need to make a new "level" named "EndLevel" for a victory screen after finishing level 3.

function OnTriggerEnter(other : Collider)
{
    if(other.gameObject.CompareTag("Player")) //This makes it so it only works if the PLAYER touches the goal, not anything else. You need to tag the player character as "Player"
    {
        Application.LoadLevel("EndLevel");
        //This makes the game load up "EndLevel" in our case would be the "You Win" screen of the game.
    }
}