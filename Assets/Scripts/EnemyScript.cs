using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float currentStepX = 0;
    float currentStepY = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentStepX = GameManager.Instance.stepSize;
            currentStepY = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x > 0)
        {
            currentStepX = -GameManager.Instance.stepSize;
            currentStepY = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            currentStepY = GameManager.Instance.stepSize;
            currentStepX = 0;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            currentStepY = -GameManager.Instance.stepSize;
            currentStepX = 0;
        }
        else
        {
            currentStepX = 0;
            currentStepY = 0;
        }
        transform.position = new Vector3(transform.position.x + currentStepX, transform.position.y + currentStepY);
    }
}
