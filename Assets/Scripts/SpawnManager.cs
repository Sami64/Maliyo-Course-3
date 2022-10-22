using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    Vector3 spawnPosition = new Vector3(25,0,0);
    PlayerController playerController;
    float startDelay = 2;
    float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
       
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if(playerController.gameOver == false)
        {

        Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
        }
    }
}
