using Unity.Mathematics;
using UnityEngine;

public class CoinCollecter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coin collected!");

        if (collision.CompareTag("player2"))
        {
            GameManager.Instance.CoinsCollected();
            //Add code to collect the box
            Destroy(gameObject);
        }
    }

    
}
