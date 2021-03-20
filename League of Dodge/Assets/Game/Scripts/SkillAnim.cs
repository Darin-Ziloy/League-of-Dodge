using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAnim : MonoBehaviour
{
    
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }
 
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            SetAnim(2);
        }
        if(Input.GetKeyDown("w"))
        {
            SetAnim(3);
        }
        if(Input.GetKeyDown("e"))
        {
            SetAnim(4);
        }
        if(Input.GetKeyDown("r"))
        {
            SetAnim(5);
        }
    }


    void SetAnim(int anim)
    {
        animator.SetInteger("state", anim);
    }

    void GetKey(string key)
    {
        Input.GetKeyDown(key);
    }

    public void SetDefoltAnim()
    {
        animator.SetInteger("state", 0);
    }

    public void SetAxeEnable()
    {
        Axe.axe.EnableAxe();
    }

    public void SetAxeDisable()
    {
        Axe.axe.DisableleAxe();
    }

}
