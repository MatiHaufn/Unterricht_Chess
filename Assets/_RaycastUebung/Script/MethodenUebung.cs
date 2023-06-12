using UnityEngine;
using UnityEngine.UI;

public class MethodenUebung : MonoBehaviour
{
    public Text text;

    float zahl1 = 0;
    float zahl2 = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            zahl1 = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            zahl1 = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            zahl2 = 3;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            zahl2 = 4;
        }
        else
        {
            text.text = ""; 
        }

        text.text = zahl1 + " + " + zahl2 + " = " + Addieren(zahl1, zahl2).ToString();
    }
    float Addieren(float x, float y)
    {
        return x + y;
    }
}

