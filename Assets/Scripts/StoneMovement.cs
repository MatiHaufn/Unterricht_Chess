using UnityEngine;

public class StoneMovement : MonoBehaviour
{
    int steps = 1;
    Vector3 movement;

    GameObject Player;
    Vector2 direction;


    private void Start()
    {
        Player = GameManager.Instance.Player; 
    }  
    public void Moving(Vector2 direction)
    {
        movement = direction * steps;
        gameObject.transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
    }

    private void Update()
    {  
        /*
        if(Player.gameObject.GetComponent<PlayerMovement>().pushed)
        {
            if(this.gameObject.transform.position.x - Player.gameObject.transform.position.x == 1 &&
                this.gameObject.transform.position.y - Player.gameObject.transform.position.y == 0)
            {
                Player.gameObject.GetComponent<PlayerMovement>().pushed = false;
                direction = new Vector2(1, 0);
            }
            else if (this.gameObject.transform.position.x - Player.gameObject.transform.position.x == -1 &&
                this.gameObject.transform.position.y - Player.gameObject.transform.position.y == 0)
            {
                direction = new Vector2(-1, 0);
                Player.gameObject.GetComponent<PlayerMovement>().pushed = false;
            }
            else if (this.gameObject.transform.position.y - Player.gameObject.transform.position.y == 1 &&
                this.gameObject.transform.position.x - Player.gameObject.transform.position.x == 0)
            {
                direction = new Vector2(0, 1);
                Player.gameObject.GetComponent<PlayerMovement>().pushed = false;
            }
            else if (this.gameObject.transform.position.y - Player.gameObject.transform.position.y == -1 &&
                this.gameObject.transform.position.x - Player.gameObject.transform.position.x == 0)
            {
                direction = new Vector2(0, -1);
                Player.gameObject.GetComponent<PlayerMovement>().pushed = false;
            }

            if (this.gameObject.transform.position == Player.gameObject.transform.position)
            {
                Moving(direction); 
            }
        }*/
    }

}
