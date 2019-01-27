using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    
    

    public int numberOfEnemies;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClearPlate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            numberOfEnemies++;
        }
    }

    private void ClearPlate()
    {
        if (numberOfEnemies <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseEnemyCount()
    {
        numberOfEnemies++;
    }

    public void DecreaseEnemyCount()
    {
        numberOfEnemies--;
    }
}
