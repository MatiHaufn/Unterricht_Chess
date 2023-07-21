using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Player;
    public GameObject Tile;
    public GameObject Stone;

    GameObject[] Stones; 
    GameObject[] Enemies; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        Stones = GameObject.FindGameObjectsWithTag("Stone");
        Enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Player.GetComponent<PlayerMovement>().ResetPosition();
            foreach (GameObject stone in Stones)
            {
                stone.GetComponent<StoneController>().ResetPosition();
            }
            foreach (GameObject enemy in Enemies)
            {
                enemy.GetComponent<PlayerMovement>().ResetPosition();
            }
        }
    }
}
