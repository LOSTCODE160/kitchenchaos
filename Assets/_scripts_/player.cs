using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

{
    [SerializeField] private float _movespeed = 7f;

    [SerializeField] private GameInput gameInput;
    private bool iswalking;
    private void Update()
    { 
       Vector2 inputvector = gameInput.GetMovementVectorNormalized();
        Vector3 movedir =  new Vector3(inputvector.x, 0f, inputvector.y);

        transform.position += movedir*_movespeed*Time.deltaTime;
        iswalking= movedir != Vector3.zero;


        float rotatespeed = 10f; 
    
        transform.forward = Vector3.Slerp (transform.forward,movedir,Time.deltaTime*rotatespeed);
        Debug.Log(Time.deltaTime); 
        
    }
    public bool IsWalking()
    {
        return iswalking;
    }

     
}
