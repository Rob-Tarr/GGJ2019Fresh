using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.name == "Player")
        {
            Destroy(gameObject);
            Other.GetComponent<Player_Movement>().MyRB.velocity= new Vector2(Other.GetComponent<Player_Movement>().MyRB.velocity.x, Other.GetComponent<Player_Movement>().JumpSpeed/1.5f);//half jump
        }
    }
}
