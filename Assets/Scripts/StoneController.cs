using UnityEngine;

public class StoneController : MonoBehaviour
{
    public Vector2 _startPosition; 
    private void Start()
    {
        _startPosition = transform.position;
    }
    public bool Move(Vector3 direction)
    {
        Vector3 origin = transform.position + direction / 2;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, 0.25f, LayerMask.GetMask("Blockade"));

        if (hit)
        {
            if (hit.collider.gameObject.tag == "Stone")
            {
                if (hit.collider.gameObject.GetComponent<StoneController>().Move(direction))
                {
                    transform.position += direction;
                }
            }
            else if (hit.collider.gameObject.tag == "Tile" && hit.collider.gameObject.GetComponent<TileScript>().imAWall)
            {
                direction = Vector3.zero;
            }
            else if (hit.collider.gameObject.tag == "Portal")
            {
                GameObject portalManager = hit.collider.gameObject.transform.GetComponentInParent<Portals>().gameObject;
                GameObject otherPortal = hit.collider.gameObject;

                if (hit.collider.gameObject == portalManager.GetComponent<Portals>()._portal1)
                    otherPortal = portalManager.GetComponent<Portals>()._portal2;
                else if (hit.collider.gameObject == portalManager.GetComponent<Portals>()._portal2)
                    otherPortal = portalManager.GetComponent<Portals>()._portal1;

                if (portalManager.GetComponent<Portals>().WallTest(otherPortal.transform.position, direction) == true)
                    direction = Vector3.zero;
                else if (portalManager.GetComponent<Portals>().WallTest(otherPortal.transform.position, direction) == false)
                {
                    transform.position = otherPortal.transform.position;
                    Move(direction);
                }
            }
            else if (hit.collider.gameObject.tag == "MovePad")
            {
                transform.position += direction;
                hit.collider.gameObject.GetComponent<MovePad>().PlatformMove(this.gameObject);
            }
            return false; 
        }
        else
        {
            transform.position += direction;
            return true; 
        }
    }

    public void ResetPosition()
    {
        this.transform.position = _startPosition; 
    }
}
