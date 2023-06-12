using UnityEngine;


public class RaycastUebung : MonoBehaviour
{
    Vector3 direction;
    float raycastLength = 2f;
    GameObject HitObject;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            direction = new Vector3(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = new Vector3(1, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = new Vector3(0, -1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            direction = new Vector3(0, 1);
        }
        else
        {
            direction = Vector3.zero;
        }

        Vector3 origin = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(direction * raycastLength, origin);

        if (hit && hit.collider.gameObject.tag == "Stone")
        {
            hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            HitObject = hit.collider.gameObject;
            Debug.DrawRay(origin, direction * raycastLength, Color.red);
        }
        else
        {
            if (HitObject != null)
            {
                HitObject.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.735849f, 0.6886254f, 0.3366857f);
            }
            Debug.DrawRay(origin, direction * raycastLength, Color.green);
        }
    }
}

