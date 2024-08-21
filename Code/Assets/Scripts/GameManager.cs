using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    int scores = 5;
    int scoreValue = 1;
    public Text scoreVal;

    [SerializeField] Color32 safeColor = new Color32(0, 0, 0, 0);
    [SerializeField] Color32 bewareColor = new Color32(0, 0, 0, 0);
    [SerializeField] Color32 dangerColor = new Color32(0, 0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        scoreVal.text = "Hits Remaining: " + scores.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreVal.text = "Hits Remaining: " + scores.ToString();
        ManageColorScore();

        

    }

    public void ManageColorScore()
    {
        if (scores > 3)
        {
            scoreVal.color = safeColor;
        }
        else if (scores >= 2)
        {
            scoreVal.color = bewareColor;
        }
        else
        {
            scoreVal.color = dangerColor;
        }

        if (scores < 1)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag != "Hit" || collision.gameObject.tag == "Hit")
        {

            scores -= scoreValue;
           


        }
    }
}
    
        




