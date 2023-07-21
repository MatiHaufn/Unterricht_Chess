using UnityEngine;

[ExecuteInEditMode]
public class MovePad : MonoBehaviour
{
    public enum Direction
    {
        up, down, left, right
    }
    public Direction dir;

    [SerializeField]GameObject arrowSprite; 
    Vector3 moveDirection;

    private void Start()
    {
        if (Application.isPlaying)
        {
            Setup();
        }
    }

    void Setup()
    {
        switch (dir)
        {
            case Direction.up:
                moveDirection = Vector3.up;
                arrowSprite.transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case Direction.down:
                moveDirection = Vector3.down;
                arrowSprite.transform.eulerAngles = new Vector3(0, 0, 270);
                break;
            case Direction.left:
                moveDirection = Vector3.left;
                arrowSprite.transform.eulerAngles = new Vector3(0, 0, 180);
                break;
            case Direction.right:
                moveDirection = Vector3.right;
                arrowSprite.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
        }
    }


    public void PlatformMove(GameObject movingObj)
    {
        movingObj.transform.position += moveDirection;
    }

    void Update()
    { 
        if(!Application.isPlaying) 
        {
            Setup();
        }
    }
}

