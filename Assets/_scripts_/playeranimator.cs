using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimator : MonoBehaviour
{   
    private const string IS_Walking = "IsWalking";
    [SerializeField]
    private player _player;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
       // animator.SetBool(Is_Walking, _player.IsWalking());
    }
}
