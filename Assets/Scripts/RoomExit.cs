using System.Collections;
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
            GameObject.FindGameObjectWithTag("Kitchen").GetComponent<MusicClass>().StopMusic();
            Destroy(GameObject.FindGameObjectWithTag("Kitchen"));
            Animator endFade;
            endFade = FindObjectOfType<Animator>();
            endFade.SetTrigger("endFade");
        }

        if (roomName == ("Controls"))
        {
            SceneManager.LoadScene(0);
        }

        if (roomName == ("Credits"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
