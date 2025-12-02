using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Playerhealth : MonoBehaviour
{
    public int health = 100;
    public Text healthText;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy")) 
        { 
            health -= 10;    
            healthText.text = "HP: " + health;
        } 
        
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

