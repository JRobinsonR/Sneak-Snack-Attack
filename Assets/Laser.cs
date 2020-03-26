using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour

{
    public Transform whatDoYouWantFromMe;
    public Transform player;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
            // This script makes it so a raycast will appear on where you click. We can alter it so it won't need a mouse click. 
            // You should attach this entire script to whatever you're using as the camera.
            
           // In order to make something happen when the ray hits something we will need to make another If statement. Need to discuss what we want that to be.
        }
        else 
        {
            Input.GetMouseButton(1); Input.GetMouseButton(2);
        }     
    }
}
