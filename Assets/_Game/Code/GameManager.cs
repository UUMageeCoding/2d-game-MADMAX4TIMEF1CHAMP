using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // single instance

    private static GameManager _instance;


    public static GameManager Instance


    {
        get { return _instance; }

    }
    private int numberOfBoxesCollected = 0;
    public TextMeshProUGUI boxCounterText;
     
     public TextMeshProUGUI healthText;
    void Awake()

    {
        // if instance already exists and it's not this

        // ensure only one instance exists

        if (_instance == null)

        {
            _instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else


        {

            Destroy(gameObject);

        }

    }
    public void BoxCollected()
    {
        numberOfBoxesCollected++;
        Debug.Log("Boxes collected: " + numberOfBoxesCollected);
        boxCounterText.text = "Boxes: " + numberOfBoxesCollected;
    }

}
    

    
