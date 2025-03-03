using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public Vector2 GetMovementVectorNormalized() 
    {
        Vector2 inputvector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputvector.y = 1;
        };
        if (Input.GetKey(KeyCode.A))
        {
            inputvector.x = -1;
        };

        if (Input.GetKey(KeyCode.S))
        {
            inputvector.y = -1;
        };

        if (Input.GetKey(KeyCode.D))
        {
            inputvector.x = 1;
        };
        inputvector = inputvector.normalized;
        return inputvector;
    }

}
