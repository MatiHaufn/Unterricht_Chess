using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps; 


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject Player;
    public GameObject tilePrefab;

    public Color gridColorEven;
    public Color gridColorUnEven;
    
    [NonSerialized] public List<GameObject> Stones = new List<GameObject>(); 
    [NonSerialized] public List<GameObject> Enemies = new List<GameObject>(); 
    [NonSerialized] public List<GameObject> Tiles = new List<GameObject>(); 
    
    public int collectibles = 0; 
    public float stepSize = 1;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        collectibles = 0; 

        foreach(GameObject stone in GameObject.FindGameObjectsWithTag("stone"))
        {
            Stones.Add(stone); 
        }
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("enemy"))
        {
            Enemies.Add(enemy);
        }
    }
    void Start()
    {
        foreach(GameObject tile in GameObject.FindGameObjectsWithTag("Tile"))
        {
            Tiles.Add(tile);
        }
    }
}
