using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public KeyCode down_Key;
    public KeyCode up_Key;
    public KeyCode right_Key;
    public KeyCode left_Key;
    public int maxDown;
    public int maxUp;
    public int maxRight;
    public int maxLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(down_Key) && transform.position.y >= maxDown)
        {
            transform.position += new Vector3(0, -1);
        }
        else if (Input.GetKeyDown(up_Key) && transform.position.y <= maxUp)
        {
            transform.position += new Vector3(0, 1);
        }
        else if (Input.GetKeyDown(right_Key) && transform.position.x <= maxRight)
        {
            transform.position += new Vector3(1, 0);
        }
        else if (Input.GetKeyDown(left_Key) && transform.position.x >= maxLeft)
        {
            transform.position += new Vector3(-1, 0);
        }
    }
}
