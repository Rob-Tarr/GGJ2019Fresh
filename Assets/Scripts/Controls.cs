﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
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
        GameObject.FindObjectOfType<AudioSource>().GetComponent<MusicClass>().StopMusic();
        SceneManager.LoadScene(7);

    }
}
