using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

{
    [SerializeField]
    private float _movespeed = 7f;
    private void Update()
    { Vector2 inputvector = new Vector2(0,0);
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
        Vector3 movedir =  new Vector3(inputvector.x, 0f, inputvector.y);

        transform.position += movedir*_movespeed*Time.deltaTime;


        float rotatespeed = 10f; 
        
        transform.forward = Vector3.Slerp (transform.forward,movedir,Time.deltaTime*rotatespeed);
        Debug.Log(Time.deltaTime); 

    }
}
