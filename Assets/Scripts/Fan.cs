using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField] Animator fanAnimator;
    Animator animator;

    bool isFanOn;

    // Start is called before the first frame update
    void Start()
    {
        isFanOn = false;
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate_DeActivate()
    {
        if (!isFanOn)
        {
            isFanOn = true;
            animator.SetBool("isFanOn", isFanOn);
            fanAnimator.SetBool("isFanOn", isFanOn);
        }
        else
        {
            isFanOn = false;
            animator.SetBool("isFanOn", isFanOn);
            fanAnimator.SetBool("isFanOn", isFanOn);
        }

    }
}
