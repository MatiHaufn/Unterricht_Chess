using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps; 


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject Player;
    public GameObject tilePrefab;
    public Tilemap _tilemap; 

    [SerializeField] Color gridColorEven;
    [SerializeField] Color gridColorUnEven;
    
    [NonSerialized] public List<GameObject> Stones = new List<GameObject>(); 
    [NonSerialized] public List<GameObject> Enemies = new List<GameObject>(); 
    [NonSerialized] public List<GameObject> Tiles = new List<GameObject>(); 
    
    public int collectibles = 0; 

    public float stepSize = 1;
    public Vector2 tileSize = new Vector2(8, 5);


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
            Stones.Add(enemy);
        }
    }
    void Start()
    {
        for (int x = 0; x < tileSize.x; x++)
        {
            for (int y = 0; y < tileSize.y; y++)
            {
                //if(_tilemap.GetTile(x))
                {

                GameObject tileClone = Instantiate(tilePrefab);

                if(Mathf.Abs(x) % 2 == 1 && y % 2 == 1 || x % 2 == 0 && y % 2 == 0)
                    tileClone.GetComponent<SpriteRenderer>().color = gridColorEven;
                else
                    tileClone.GetComponent<SpriteRenderer>().color = gridColorUnEven;

                tileClone.transform.position = tilePrefab.transform.position + new Vector3(x, y);
                Tiles.Add(tileClone); 
                }
            }
        }

        for (int x = 0; x < tileSize.x; x++)
        {
            for (int y = 0; y < tileSize.y; y++)
            {
                GameObject tileClone = Instantiate(tilePrefab);
                tileClone.transform.position = tilePrefab.transform.position + new Vector3(x, y);
                Tiles.Add(tileClone);
            }
        }
    }
}
