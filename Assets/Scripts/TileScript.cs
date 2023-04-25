using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool _playerOnTile; 
    public bool _stoneOnTile; 
    public bool _wallOnTile;
    public bool _enemyOnTile;

    private void Start()
    {

        
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

        if (this.transform.position.x == GameManager.Instance.tileSize.x - 1 || this.transform.position.x == 0 || this.transform.position.y == GameManager.Instance.tileSize.y - 1|| this.transform.position.y == 0)
        {
            _wallOnTile = true; 
            this.GetComponent<SpriteRenderer>().color = new Color(.28f, .28f, .28f);
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
