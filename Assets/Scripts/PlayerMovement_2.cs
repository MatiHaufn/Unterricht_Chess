using UnityEngine;

public class PlayerMovement_2 : MonoBehaviour
{
    float currentStepX = 0; 
    float currentStepY = 0;
    public bool pushed = false;
    Vector2 lastPosition; 

    void Update()
    {
        lastPosition = transform.position;   
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > 0)
        {
            currentStepX = -GameManager.Instance.stepSize;
            currentStepY = 0;
            pushed = true; 
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < GameManager.Instance.tileSize.x - GameManager.Instance.stepSize)
        {
            currentStepX = GameManager.Instance.stepSize;
            currentStepY = 0;
            pushed = true; 
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > 0)
        {
            currentStepY = -GameManager.Instance.stepSize;
            currentStepX = 0;
            pushed = true; 
        }
        else if (Input.GetKeyDown(KeyCode.W) && transform.position.y < GameManager.Instance.tileSize.y - GameManager.Instance.stepSize)
        {
            currentStepY = GameManager.Instance.stepSize;
            currentStepX = 0;
            pushed = true; 
        }
        else
        {
            currentStepX = 0;
            currentStepY = 0;
        }

        transform.position = new Vector3(transform.position.x + currentStepX, transform.position.y + currentStepY);


        foreach(GameObject tile in GameManager.Instance.Tiles)
        {
            if (tile.GetComponent<TileScript>()._wallOnTile == true)
            {
                if (transform.position == tile.transform.position)
                {
                    transform.position = lastPosition; 
                }
            }
        }
    }

}
