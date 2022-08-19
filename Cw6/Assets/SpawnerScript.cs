using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject Enemy;

    public float delay; 

    public Transform leftPos;
    public Transform rightPos;
    public Transform midPos; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, delay); 
    }

    
    
    void Spawn()
    {
        int randomPos = Random.Range(1, 4);

        if (randomPos == 1)
        {
            Instantiate(Enemy, leftPos);
            
        }
        else if (randomPos == 2)
        {
            Instantiate(Enemy, rightPos);
        }
        else
        {
            Instantiate(Enemy, midPos);
        }
    }
}
