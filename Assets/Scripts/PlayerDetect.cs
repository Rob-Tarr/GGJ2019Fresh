using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public GameObject myEnemy;
    public Plate myPlate;
   

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

            GameObject.FindGameObjectWithTag("Kitchen_L").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Kitchen_L"));
            Application.LoadLevel(Application.loadedLevel);

        }

        if(collision.tag == "Plate")
        {

            myPlate = collision.GetComponent<Plate>();
            myPlate.IncreaseEnemyCount();
            
        }

        if(collision.tag == "Attack")
        {
            Debug.Log("TOUCHINGGGG");

            myPlate.DecreaseEnemyCount();
            Destroy(myEnemy);
            
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
