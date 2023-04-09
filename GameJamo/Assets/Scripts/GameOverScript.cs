using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.HID.HID;

public class GameOverScript : MonoBehaviour
{
    public Button button;

    void Start()
    {
        
    }

    

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Next();
        }
        
    }
    void Next()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene(0);
        }
           
    }
}
