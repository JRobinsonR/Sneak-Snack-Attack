using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ColliderLights : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider triggerReport) // this will store information on collider trigger
    {
        Debug.Log("TRIGGER ENTERED");
        if (triggerReport.name == "Steve") { //this checks the name of whatever thing entered the trigger zone. in this case steve.
        //We can change this name to anything in our game. Probably whatever we decide to name our player. 

            //If we use this for spotlights this script will make the spotlight react to the player and only the player not anything else it may see.
            //Need to discuss what we want to happen when getting spotted in the spotlight before adding more to this script.
        } 
    }
}
