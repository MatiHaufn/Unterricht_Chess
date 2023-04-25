using System;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this); 
    }

    public GameObject mainCamera; 
    public GameObject tilePrefab;

    public int tileWidth;
    public int tileHeight;

    public int gridSizeX;
    public int gridSizeY;

    [NonSerialized] public float xTileScale = 1; 
    [NonSerialized] public float yTileScale = 1; 

    public Color GridColorEven;
    public Color GridColorUnEven; 

    List<GameObject> tiles = new List<GameObject>();

    public void CreateTiles()
    {
        foreach(GameObject tile in tiles)
        {
            DestroyImmediate(tile);
        }
        
        tiles = new List<GameObject>();
        
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                GameObject newTile = Instantiate(tilePrefab);

                if (x % 2 == 1 && y % 2 == 1 || x % 2 == 0 && y % 2 == 0)
                {
                    newTile.GetComponent<SpriteRenderer>().color = GridColorEven; 
                }
                else 
                {
                    newTile.GetComponent<SpriteRenderer>().color = GridColorUnEven; 

                }

                newTile.transform.SetParent(gameObject.transform);
                newTile.transform.position = Vector2.zero + new Vector2(x, y); 
                tiles.Add(newTile);
            }
        }
        mainCamera.transform.position = new Vector3((tileWidth * gridSizeX) / 2, (tileHeight * gridSizeY) / 2, mainCamera.transform.position.z);
    }
}
