using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimator : MonoBehaviour
{   
    private const string IS_WALKING = "IsWalking";
    [SerializeField]
    private player _player;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool(IS_WALKING, _player.IsWalking());
    }
    private void Update()
    {
        
    }
}
