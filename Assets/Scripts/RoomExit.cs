﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomExit : MonoBehaviour
{

    [SerializeField] string roomName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        DetectRoom();
    }

    private void OnMouseOver()
    {
        // transition effect
    }

    private void DetectRoom()
    {
        if (roomName == ("Bedroom"))
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Music"));
            SceneManager.LoadScene("02 Living Room");  
        }

        if (roomName == ("Living"))
        {
            GameObject.FindGameObjectWithTag("Living").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Living"));
            SceneManager.LoadScene("04 Kitchen");
        }

        if (roomName == ("Kitchen"))
        {
            SceneManager.LoadScene("06 Outside");
        }

        if (roomName == ("End"))
        {
            Animator endFade;
            endFade = FindObjectOfType<Animator>();
            endFade.SetTrigger("endFade");
            GameObject.FindGameObjectWithTag("Kitchen").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Kitchen"));

        }

        if (roomName == ("Controls"))
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Music"));
            SceneManager.LoadScene(0);
        }

        if (roomName == ("Credits"))
        {
            GameObject.FindGameObjectWithTag("Credits").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Credits"));
            SceneManager.LoadScene(0);
        }
    }

}
