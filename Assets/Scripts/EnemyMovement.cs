using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed;

    Rigidbody2D myRigidbody;

    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidbody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    bool IsFacingRight()
    {
        return myRigidbody.velocity.x > 0;
    }

    public void Die()
    {

    }
}
