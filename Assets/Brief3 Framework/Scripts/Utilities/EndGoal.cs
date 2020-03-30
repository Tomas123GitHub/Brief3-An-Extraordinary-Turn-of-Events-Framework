using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Script: EndGoal
    Author: Gareth Lockett
    Version: 1.0
    Description:    ...
*/

public class EndGoal : MonoBehaviour
{
    // Properties
    public GameObject ball;                 // Reference to the ball game object.

    // Methods
    private void OnTriggerEnter( Collider other )
    {
        if( other.gameObject == this.ball )
        {
            Debug.Log( "Ball in end goal!" );
        }
    }
}
