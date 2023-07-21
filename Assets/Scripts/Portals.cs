using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Portals : MonoBehaviour
{
    public GameObject _portal1;
    public GameObject _portal2;
    
    bool wallahead = false; 

    public bool WallTest(Vector3 origin, Vector3 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(origin + direction, direction, 0.25f, LayerMask.GetMask("Blockade"));
        Debug.DrawRay(origin + direction, direction, Color.red);

        if (hit)
        {
            if(hit.collider.gameObject.tag == "Tile" && hit.collider.gameObject.GetComponent<TileScript>().imAWall)
            {
                //Debug.Log("Wall ahead");
                wallahead = true;          
            }
        }
        else
        {
            //Debug.Log("NO Wall");
            wallahead = false;
        }

        return wallahead; 
    }

    public Vector2 TeleportPlayer(GameObject portal)
    {
        if (portal == _portal1)
            return _portal2.transform.position;
        else if (portal == _portal2)
            return _portal1.transform.position;
        else
            return portal.transform.position; 
    }
}
