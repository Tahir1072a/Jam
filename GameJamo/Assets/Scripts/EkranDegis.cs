using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EkranDegis : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(MyButtonClick);
    }

    void MyButtonClick()
    {
        Debug.Log("Button clicked!");
    }

    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (button != null)
            {
                button.onClick.Invoke();
            }
        }

    }
}
