using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    AudioSource myAudioSource;

    private void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Other)
    {
        myAudioSource = FindObjectOfType<AudioSource>();
        if (Other.name == "Player")
        {
            myAudioSource.Stop();
            Destroy(myAudioSource.gameObject);
            Application.LoadLevel(Application.loadedLevel);

        }
    }
}
