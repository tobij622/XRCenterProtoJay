 using UnityEngine;
 using System.Collections;
  
 public class MenuAppearScript : MonoBehaviour {
  
     public GameObject menu; // Assign in inspector
     private bool isShowing = true;
 
     void Update() {
         if (Input.GetKeyDown("escape")) {
             isShowing = !isShowing;
             menu.SetActive(isShowing);
         }
     }
 }
