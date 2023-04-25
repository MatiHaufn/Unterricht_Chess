using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float currentStepX = 0; 
    float currentStepY = 0;
    public bool pushed = false;
    Vector2 lastPosition;


    void Update()
    {
        lastPosition = transform.position; 
        
        foreach(GameObject tile in GameManager.Instance.Tiles)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if(tile.transform.position.x == this.transform.position.x - 1 && tile.transform.position.y == this.transform.position.y)
                {
                   if(!tile.GetComponent<TileScript>()._enemyOnTile || !tile.GetComponent<TileScript>()._wallOnTile)
                   {
                        currentStepX = -GameManager.Instance.stepSize;
                        currentStepY = 0;
                        if (tile.GetComponent<TileScript>()._stoneOnTile)
                        {
                            Debug.Log("trueeee A");
                        }
                   }
                   else
                   {
                        break; 
                   }
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (tile.transform.position.x == this.transform.position.x + 1 && tile.transform.position.y == this.transform.position.y)
                {
                    if (!tile.GetComponent<TileScript>()._enemyOnTile || !tile.GetComponent<TileScript>()._wallOnTile)
                    {
                        currentStepX = GameManager.Instance.stepSize;
                        currentStepY = 0;
                        if (tile.GetComponent<TileScript>()._stoneOnTile)
                        {
                            Debug.Log("trueeee D");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (tile.transform.position.x == this.transform.position.x && tile.transform.position.y == this.transform.position.y - 1)
                {
                    if (!tile.GetComponent<TileScript>()._enemyOnTile || !tile.GetComponent<TileScript>()._wallOnTile)
                    {
                        currentStepY = -GameManager.Instance.stepSize;
                        currentStepX = 0;
                        if (tile.GetComponent<TileScript>()._stoneOnTile)
                        {
                            Debug.Log("trueeee S");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                if (tile.transform.position.x == this.transform.position.x && tile.transform.position.y == this.transform.position.y + 1)
                {
                    if (!tile.GetComponent<TileScript>()._enemyOnTile || !tile.GetComponent<TileScript>()._wallOnTile)
                    {
                        currentStepY = GameManager.Instance.stepSize;
                        currentStepX = 0;
                        if (tile.GetComponent<TileScript>()._stoneOnTile)
                        {
                            Debug.Log("trueeee W");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                currentStepX = 0;
                currentStepY = 0;
            }

        }

        transform.position = new Vector3(transform.position.x + currentStepX, transform.position.y + currentStepY);
        
    }

  
}
