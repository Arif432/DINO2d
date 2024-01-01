using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isWalk", false);
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f,0,0);
            anim.SetBool("isWalk", true);
        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f,0,0);
            anim.SetBool("isWalk", true);
        }

          if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0.1f,0);
            anim.SetBool("isWalk", true);
        }

           if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,-0.1f,0);
            anim.SetBool("isWalk", true);
        }
    }
}