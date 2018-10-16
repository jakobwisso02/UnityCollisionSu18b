using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{



    public Rigidbody2D rbody;


    void Start()
    {

        //rbody.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse); // Player får direkt x antal newton i y-axeln utan accelerering // void Start = Kraft direkt

    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {

            SceneManager.LoadScene("SampleScene");

        }

    }

    // Allt med fysik att göra läggs här
    void FixedUpdate() // Som update bara att den uppdaterar konstant 50 ggr
    {

        if (Input.GetKey(KeyCode.D))
        {

            rbody.AddForce(new Vector2(10f, 0f));

        }

        if (Input.GetKey(KeyCode.A))
        {

            rbody.AddForce(new Vector2(-10f, 0f));

        }

        if (Input.GetKey(KeyCode.W))
        {

            rbody.AddForce(new Vector2(0f, 10f));

        }

        if (Input.GetKey(KeyCode.S))
        {

            rbody.AddForce(new Vector2(0f, -10f));

        }

        // rbody.AddForce
        // rbody.AddRelativeForce
        // rbody.AddTorque
        // rbody.MovePosition
        // rbody.MoveRotation
        // rbody.velocity
        // AddForce är najs när man ska putta saker
        // void FixedUpdate = Kraft efter tid

    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene("SampleScene");
       
    }




}
