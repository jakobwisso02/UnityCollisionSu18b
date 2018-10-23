using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public Animator anim;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("EPIC", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("EPIC", false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("trigga");
        }

    }

    void MinCoolaTestFunktion()
    {
        print("MY MANGO IS TO BLOW UP, AND ACT LIKE I DONT KNOW NOBADY EH EH EH EH");
        print("ERIK EKORRE STAL MIN MAYMAY"); 
    }

}
