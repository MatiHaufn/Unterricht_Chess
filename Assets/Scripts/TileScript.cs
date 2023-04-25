using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool _playerOnTile; 
    public bool _stoneOnTile; 
    public bool _wallOnTile;
    public bool _enemyOnTile;

    Vector3 _playerDirection = Vector3.zero;
    Vector2 position; 

    private void Start()
    {
        position = transform.position;

        if (position.x % 2 == 0 && position.y % 2 == 0 || position.x % 2 != 0 && position.y % 2 != 0)
            GetComponent<SpriteRenderer>().color = GameManager.Instance.gridColorEven;
        else
            GetComponent<SpriteRenderer>().color = GameManager.Instance.gridColorUnEven; 
        
        if(GameManager.Instance.Player.transform.position == this.transform.position)
            _playerOnTile = true;
        else
            _playerOnTile = false;

        foreach(GameObject stone in GameManager.Instance.Stones)
        {
            if(stone.transform.position == this.transform.position)
                _stoneOnTile = true;
            else
                _stoneOnTile = false;
        }

        foreach (GameObject enemy in GameManager.Instance.Enemies)
        {
            if (enemy.transform.position == this.transform.position)
                _enemyOnTile = true;
            else
                _enemyOnTile = false;
        }
    }
    private void Update()
    {
        if (GameManager.Instance.Player.transform.position == this.transform.position)
            _playerOnTile = true;
        else
            _playerOnTile = false;

        foreach (GameObject stone in GameManager.Instance.Stones)
        {
            if (stone.transform.position == this.transform.position)
                _stoneOnTile = true;
            else
                _stoneOnTile = false;
        }

        foreach (GameObject enemy in GameManager.Instance.Enemies)
        {
            if (enemy.transform.position == this.transform.position)
                _enemyOnTile = true;
            else
                _enemyOnTile = false;
        }
    }
}
