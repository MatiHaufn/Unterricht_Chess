using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTuer : MonoBehaviour
{
    public Animator tor;
    public Rigidbody2D rb; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Key")
        {
            tor.SetBool("bool", true);
        }

    }
}
