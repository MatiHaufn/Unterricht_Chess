using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    float xTileScale; 
    float yTileScale; 

    private void Start()
    {
        xTileScale = GridManager.Instance.xTileScale;
        yTileScale = GridManager.Instance.yTileScale; 
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && transform.position.y < (GridManager.Instance.gridSizeY - 1) * yTileScale)
        {
            Move(0, 1 * (int)xTileScale); 
        }
        else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && transform.position.y > 0)
        {

            Move(0, -1 * (int)xTileScale); 
        }
        else if((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && transform.position.x > 0)
        {

            Move(-1 * (int)yTileScale, 0); 
        }
        else if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && transform.position.x < (GridManager.Instance.gridSizeX - 1)* xTileScale)
        {

            Move(1 * (int)yTileScale, 0); 
        }
        
    }

    private void Move(float xDir, float yDir)
    {
        transform.position += new Vector3(xDir, yDir);
        Debug.Log(transform.position);
    }
}
