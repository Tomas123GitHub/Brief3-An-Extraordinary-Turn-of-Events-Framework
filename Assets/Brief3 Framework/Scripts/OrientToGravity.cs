using UnityEngine;

/*
    Script: CameraGravity
    Author: Gareth Lockett
    Version: 1.0
    Description:    Orients the game object so its up is always pointing in the opposite direction of gravity.
*/

public class OrientToGravity : MonoBehaviour
{
    // Methods
    private void Update()
    {
        // Orient this game object so its up vector is the opposite of the gravity direction.
        this.transform.LookAt( this.transform.position + this.transform.forward, -Physics.gravity );
    }
}
