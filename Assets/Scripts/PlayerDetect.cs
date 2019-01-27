using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponentInParent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            
        }
        if (collision.name == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if(collision.tag == "Plate")
        {
            Plate myPlate;

            myPlate = collision.GetComponent<Plate>();
            myPlate.numberOfEnemies++;
        }

        if(collision.tag == "Attack")
        {
            Plate myPlate;

            myPlate = collision.GetComponent<Plate>();
            myPlate.numberOfEnemies--;

            GameObject gameObject;
            gameObject = GetComponentInParent<GameObject>();
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Plate")
        {
            Plate myPlate;

            myPlate = collision.GetComponent<Plate>();
            myPlate.numberOfEnemies--;
        }
    }




}
