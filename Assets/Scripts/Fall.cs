using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    //private Scene thisScene;
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.name == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
            //thisScene = SceneManager.GetActiveScene();
            //if (thisScene.name == "03 Level 1")
            //{
            //    GameObject.FindGameObjectWithTag("Level_L").GetComponent<MusicClass>().StopMusic();
            //    Application.LoadLevel(Application.loadedLevel);
            //}
            //if(thisScene.name == "05 Level 2")
            //{
            //    Application.LoadLevel(Application.loadedLevel);
            //    GameObject.FindGameObjectWithTag("Kitchen_L").GetComponent<MusicClass>().StopMusic();
            //}

        }
    }
}
