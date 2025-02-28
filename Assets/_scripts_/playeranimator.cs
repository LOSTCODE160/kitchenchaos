using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimator : MonoBehaviour
{   private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

}
