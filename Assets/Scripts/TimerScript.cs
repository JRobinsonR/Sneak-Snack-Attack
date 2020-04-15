using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
  
  //Don't forget to include the unity asset stuff at the top ^ I couldn't add them myself.
  
  //Make a canvas with the assets and attach this script to that.... I think
  
  //Change file type if needed
  
  public Text timerText;
     private float secondsCount;
     private int minuteCount;
     private int hourCount;
     void Update(){
         UpdateTimerUI();
     }
 //call this on update
     public void UpdateTimerUI(){
         //set timer UI
         secondsCount += Time.deltaTime;
         timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s";
         if(secondsCount >= 60){
             minuteCount++;
             secondsCount = 0;
         }else if(minuteCount >= 60){
             hourCount++;
             minuteCount = 0;
         }    
     }