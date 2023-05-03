using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log (score);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.dobuleSpeed == true) 
        {
            score += 2;
        }
        else
        {
            score += 1;
        }
        
        if(playerController.gameOver == false)
        {
            Debug.Log(score);
        }
    }
}
