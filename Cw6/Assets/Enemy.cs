using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{

    Rigidbody RB;

    public int Score;
    public Text ScoreText;

    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

    }
    void Move()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
      
        {
            Destroy(gameObject);
            
        }




    }
}
