using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class MainMenu : MonoBehaviour {
 
   
    void Start () {
       
    }
   
    
    void Update () {
 
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     
            Debug.Log("Quit Game"); 
        }
    }
 
 
   
    public void MainGame()
    {
        
           SceneManager.LoadScene("GamePlay");
    }
}
