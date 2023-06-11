using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    /*
    public KeyCode down_Key;
    public KeyCode up_Key;
    public KeyCode right_Key;
    public KeyCode left_Key;
    public int maxDown;
    public int maxUp;
    public int maxRight;
    public int maxLeft;
    public GameObject[] Tiles;
    public GameObject[] Stones;
    */
    
    public GameObject Player;
    public GameObject Tile;
    public GameObject Stone;
    public Color tileColorEven;
    public Color tileColorUneven;
    public Color tileColorWall;

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
        
        /*
        Tiles = GameObject.FindGameObjectsWithTag("Tile");
        Stones = GameObject.FindGameObjectsWithTag("Stone");
        */
    }
}
