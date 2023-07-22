using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Distance : MonoBehaviour
{
    public GameObject second;
    public TMP_Text text; 

    void Update()
    {
        text.text = Vector3.Distance(transform.position, second.transform.position).ToString();

        //Welcher Vector ist größer?
        if (Vector3.Max(transform.position, second.transform.position) == transform.position)
            Debug.Log(gameObject.name);
        else
            Debug.Log(second.name);
    }
}
