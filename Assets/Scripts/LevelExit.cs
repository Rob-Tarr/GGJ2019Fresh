using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] string roomName;

    DishManager myDishes;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            DetectRoom();
        }
    }

    private void DetectRoom()
    {
        if (roomName == ("Living Room"))
        {
            GameObject.FindGameObjectWithTag("Living_L").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Living_L"));
            SceneManager.LoadScene("02 Living Room");
        }

        if (roomName == ("Kitchen"))
        {
            GameObject.FindGameObjectWithTag("Kitchen_L").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Kitchen_L"));
            GameObject.FindObjectOfType<DishManager>().RemoveDishes();
            SceneManager.LoadScene("04 Kitchen");
        }

        if (roomName == ("Laundry"))
        {
            SceneManager.LoadScene("06 Laundry Room");
        }
    }
}
