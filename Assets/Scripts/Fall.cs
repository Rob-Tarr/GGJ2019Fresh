using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = FindObjectOfType<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.name == "Player")
        {
            myAudioSource.Stop();
            Destroy(myAudioSource.gameObject);
            Application.LoadLevel(Application.loadedLevel);

        }
    }
}
