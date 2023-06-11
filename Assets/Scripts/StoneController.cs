using UnityEngine;

public class StoneController : MonoBehaviour
{
    public bool Move(Vector3 direction)
    {
        Vector3 origin = transform.position + direction / 2;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, 0.25f, LayerMask.GetMask("Blockade"));

        if (hit)
        {
            if (hit.collider.gameObject.tag == "Stone")
            {
                Debug.Log("Stone!!");
                direction = Vector3.zero;
            }
            else if (hit.collider.gameObject.tag == "Tile" && hit.collider.gameObject.GetComponent<TileScript>().imAWall)
            {
                Debug.Log("WALL!!");
                direction = Vector3.zero;
            }
            return false; 
        }
        else
        {
            transform.position += direction;
            return true; 
        }

    }
}
