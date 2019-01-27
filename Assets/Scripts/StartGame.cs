using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    private ButtonController myButton;


    // Start is called before the first frame update
    void Start()
    {
        myButton = FindObjectOfType<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        myButton.StartGame();
    }
}
