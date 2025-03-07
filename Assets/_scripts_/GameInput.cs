using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputAction PlayerInputAction;
    private void Awake()
    {
        PlayerInputAction = new PlayerInputAction();
        PlayerInputAction.player.Enable();

    }

    public Vector2 GetMovementVectorNormalized() 

    {
      
        Vector2 inputvector = new Vector2(0, 0);
        PlayerInputAction.player.move.ReadValue<Vector2>();
        inputvector = inputvector.normalized;
        return inputvector;
    }

}
