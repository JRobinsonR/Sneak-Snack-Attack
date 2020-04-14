//Add the Unity stuff at the top

//This script is to move between levels once the player reaches the fridge. Attach this script to the "fridge"

//Change file type if needed

function OnTriggerEnter ()
{
Application.LoadLevel ("scenename");
}