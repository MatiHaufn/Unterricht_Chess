using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public float radius;
    public float speed;
    public float rotationSpeed;

    private float angle = 0f;

    void Update()
    {
        // Ändere den Winkel basierend auf der Geschwindigkeit und der Zeit
        angle += speed * Time.deltaTime;

        // Berechne die neue Position des GameObjects im Kreis mithilfe von Sinus und Cosinus
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, 0.0f);

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
