using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required in order to use the SceneManager
#if UNITY_EDITOR // # is used to indicate instructions for the compiler
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
    }
    
    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        // INSIDE THE UNITY EDITOR:
        // 1) File > Build Settings... > (A list of the project scenes will appear, each one associated with a number)
        // 2) Select the StartButton GameObject and assign this method to it, using the 'On Click()' property under the 'Button' component

    }

    public void Exit()
    {   
        // # is used to indicate instructions for the compiler
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
