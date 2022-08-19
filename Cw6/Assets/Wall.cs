using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wall : MonoBehaviour
{
    public int Score;
    public Text ScoreText;



    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        AddScore(); 
    }
    
    void AddScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
        
    }
    
       


    

