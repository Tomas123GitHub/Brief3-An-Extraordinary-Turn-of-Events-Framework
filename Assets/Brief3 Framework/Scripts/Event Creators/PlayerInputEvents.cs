
using UnityEngine;
using UnityEngine.Events;

/*
    Script: PlayerInputEvents
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple script for invoking a UnityEvent when a key is pressed on the keyboard.
*/

public class PlayerInputEvents : MonoBehaviour
{
    // Events
    public UnityEvent keyPressed;                   // Invoked whenever the action key is pressed.

    // Properties
    public KeyCode key = KeyCode.Space;             // The key to press to invoke the 'key pressed' event.
    public bool singlePress = true;                 // If this is set to true, then will only invoke events when the key is first pressed. Otherwise will invoke each Update/frame the key is held down on.

    // Methods
    private void Update()
    {
        // Check for key pressed. If using singlePress then check with Input.GetKeyDown() otherwise check with Input.GetKey() (See unity Scripting Reference for more on these)
        bool keyIsPressed = false;
        if( this.singlePress == true )
        {
            if( Input.GetKeyDown( this.key ) == true ) { keyIsPressed = true; } // Check if the key has been pressed since last Update.
        }
        else
        {
            if( Input.GetKey( this.key ) == true ) { keyIsPressed = true; } // Check if the key is currently pressed (Eg held down)
        }

        // If key is pressed, check to invoke event.
        if( keyIsPressed == true )
        {
            if( this.keyPressed != null )    // Check some methods have subscribed to the leftKeyPressed event.
            {
                this.keyPressed.Invoke();    // Invoke any methods that have subscribed to the leftKeyPressed event.
            }
        }

    }
}
