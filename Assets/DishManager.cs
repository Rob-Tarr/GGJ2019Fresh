using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishManager : MonoBehaviour
{
    public bool flag;
    // Start is called before the first frame update
    public void setFlag(bool f)
    {
        flag = f;
    }

    void Start()
    {
        if (GameObject.FindObjectOfType<DishManager>()) Destroy(this);
        flag = true;
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!flag)
        {
            GameObject.FindGameObjectWithTag("Dish").gameObject.SetActive(false);
        }
    }



}
