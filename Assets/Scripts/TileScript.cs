using UnityEngine;

//Wird auch im EditMode ausgeführt
[ExecuteInEditMode]
public class TileScript : MonoBehaviour
{
    public Color tileColorEven;
    public Color tileColorUneven;
    public Color tileColorWall;

    public bool playerContact;
    public bool imAWall = false;

    void Update()
    {
        if(this != null)
        {
            if (Mathf.Abs(transform.position.x + transform.position.y) % 2 == 1)
            {
                GetComponent<SpriteRenderer>().color = tileColorUneven;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = tileColorEven;
            }
        
            if (imAWall == true)
            {
                GetComponent<SpriteRenderer>().color = tileColorWall;
                gameObject.layer = LayerMask.NameToLayer("Blockade"); 
            }
            else
            {

                gameObject.layer = LayerMask.NameToLayer("Default"); 
            }
        }
    }
}
