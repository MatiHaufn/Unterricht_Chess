using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Wird auch im EditMode ausgeführt
[ExecuteInEditMode]
public class TileScript : MonoBehaviour
{
    public bool playerContact;
    public bool imAWall = false;

    void Start()
    {
        if (Mathf.Abs(transform.position.x + transform.position.y) % 2 == 1)
        {
            GetComponent<SpriteRenderer>().color = GameManager.Instance.tileColorUneven;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = GameManager.Instance.tileColorEven;
        }
        
        if (imAWall == true)
        {
            GetComponent<SpriteRenderer>().color = GameManager.Instance.tileColorWall;
            gameObject.layer = LayerMask.NameToLayer("Blockade"); 
            //GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Player.transform.position == this.transform.position)
        {
            playerContact = true;
        }
        else
        {
            playerContact = false;
        }
    }*/
}
