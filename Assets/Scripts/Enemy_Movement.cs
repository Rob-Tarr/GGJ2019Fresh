using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour


    
{
    public float speed = 5f;
    bool MovingRight, MovingLeft;
    private Transform Right, Left;
    public Vector3 ADD;
    // Start is called before the first frame update
    void Start()
    {
        
        MovingRight = false;
        MovingLeft = true;

        Right = gameObject.transform.GetChild(0);
        Left = gameObject.transform.GetChild(1);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (MovingLeft)
        {
            ADD= -new Vector3(Time.deltaTime * speed, 0f, 0f);
            transform.position += ADD;
            if (transform.position.x<Left.position.x) //moved past leftmost
            {
                MovingLeft = false;
                MovingRight = true;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }

        }
        else if (MovingRight)
        {
            ADD = new Vector3(Time.deltaTime * speed, 0f, 0f);
            transform.position += ADD;
            if (transform.position.x > Right.position.x) //moved past leftmost
            {
                MovingLeft = true;
                MovingRight = false;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;

            }

        }
    }
}
