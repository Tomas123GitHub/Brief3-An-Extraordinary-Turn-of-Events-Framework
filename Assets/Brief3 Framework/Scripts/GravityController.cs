using UnityEngine;

/*
    Script: GravityController
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple script that subscribes to PlayerInput and listens for left/right key presses and rotates the direction og gravity.
*/

public class GravityController : MonoBehaviour
{
    // Properties
    public float rotationSpeed = 10f;           // Speed at which the direction of gravity is rotated (Degrees per second)

    // Methods
    private void Start()
    {
        // Subscribe/listen for left/right key input events.
        PlayerInput.leftKeyPressed += this.LeftKeyPressed; // << This subscribes this class's LeftKeyPressed() to the PlayerInput.leftKeyPressed action. Meaning, whenever PlayerInput.leftKeyPressed is called/invoked LeftKeyPressed() will be executed.
        PlayerInput.rightKeyPressed += this.RightKeyPressed;
        //PlayerInput.actionKeyPressed += this.ActionKeyPressed;
    }

    private void LeftKeyPressed()
    {
        // This line rotates the current gravity direction anti-clockwise around the world Z axis.
        Physics.gravity = Quaternion.Euler( 0f, 0f, -this.rotationSpeed * Time.deltaTime ) * Physics.gravity;
    }

    private void RightKeyPressed()
    {
        // This line rotates the current gravity direction clockwise around the world Z axis.
        Physics.gravity = Quaternion.Euler( 0f, 0f, this.rotationSpeed * Time.deltaTime ) * Physics.gravity;
    }

    //private void ActionKeyPressed()
    //{

    //}
}
