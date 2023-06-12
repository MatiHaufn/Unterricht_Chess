using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode down_Key;
    public KeyCode up_Key;
    public KeyCode right_Key;
    public KeyCode left_Key;
    public Vector3 moves;
    Rigidbody2D _myRigidbody; 

    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();
        moves = Vector3.zero; 
    }

    void Update()
    {    
        if (Input.GetKeyDown(down_Key))
        {
            moves = new Vector3(0, -1);
            Move(moves);
        }
        else if (Input.GetKeyDown(up_Key))
        {
            moves = new Vector3(0, 1);
            Move(moves);
        }
        else if (Input.GetKeyDown(right_Key))
        {
            moves = new Vector3(1, 0);
            Move(moves);
        }
        else if (Input.GetKeyDown(left_Key))
        {
            moves = new Vector3(-1, 0);
            Move(moves);
        }

        //Raycast wird gezeichnet, nur zu Debug-Zwecken
        Vector3 origin = transform.position + moves / 2;
        Debug.DrawRay(origin, moves, Color.green);
    }
    void Move(Vector3 direction)
    {
        Vector3 origin = transform.position + direction / 2; 
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, 0.25f, LayerMask.GetMask("Blockade"));
        
        if(hit)
        {
            if (hit.collider.gameObject.tag == "Stone")
            {
                Debug.Log("Stone!!");
                if(hit.collider.gameObject.GetComponent<StoneController>().Move(direction))
                    transform.position += direction;

            }
            else if(hit.collider.gameObject.tag == "Tile" && hit.collider.gameObject.GetComponent<TileScript>().imAWall)
            {
                Debug.Log("WALL!!"); 
                direction = Vector3.zero; 
            }
        }
        else if(!hit)
        {
            transform.position += direction;
        }
    }
}

