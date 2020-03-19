using System;
using UnityEngine;

/*
    Script: PlayerInput
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple input script. Will invoke events when set keys are pressed.
*/

public class PlayerInput : MonoBehaviour
{
    // Actions
    public static Action leftKeyPressed;            // Action to invoke when the left key is pressed.
    public static Action rightKeyPressed;           // Action to invoke when the right key is pressed.
    public static Action actionKeyPressed;          // Action to invoke when the action key is pressed.

    // Properties
    public KeyCode leftKey = KeyCode.LeftArrow;     // The key to press to invoke 'left key pressed' action.
    public KeyCode rightKey = KeyCode.RightArrow;   // The key to press to invoke 'right key pressed' action.
    public KeyCode actionKey = KeyCode.Space;       // The key to press to invoke 'action key pressed' action.

    // Methods
    private void Update()
    {
        // Check for key pressed.
        if( Input.GetKey( this.leftKey ) == true )      // Check if the left key is being pressed.
        {
            if( PlayerInput.leftKeyPressed != null )    // Check some methods have subscribed to the leftKeyPressed action.
            {
                PlayerInput.leftKeyPressed.Invoke();    // Invoke any methods that have subscribed to the leftKeyPressed action.
            }
        }

        // Do the same for the right key.
        if( Input.GetKey( this.rightKey ) == true ) { if( PlayerInput.rightKeyPressed != null ) { PlayerInput.rightKeyPressed.Invoke(); } }

        // Check if the action key has been pressed (Note: Using Input.GetKeyDown, which checks for key single press and not held down)
        if( Input.GetKeyDown( this.actionKey ) == true ) { if( PlayerInput.actionKeyPressed != null ) { PlayerInput.actionKeyPressed.Invoke(); } }
    }
}
