using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    public int Offset = 20;

    public RawImage MinimapImage;

    public Transform Player;

    public GameObject PlayerDot;
    public GameObject EnemyDot;

    public List<Vector2> PlayerPosition = new List<Vector2>();

    private List<GameObject> _instances = new List<GameObject>();
    private GameObject _playerDotInstance;
    void Start()
    {
        GameObject player = Instantiate(PlayerDot, this.MinimapImage.transform);
        _playerDotInstance = player;
    }

    // Update is called once per frame
    void Update()
    {
        _playerDotInstance.transform.localPosition = new Vector2(Player.position.x * Offset, Player.position.z * Offset);
    }

    public void AddNewPlayer()
    {
        GameObject enemy = Instantiate(EnemyDot, this.MinimapImage.transform);
        _instances.Add(enemy);
    }

    public void ChangePosition(Vector3 position, int id)
    {
        _instances[id].transform.localPosition = new Vector2(position.x * Offset, position.z * Offset);
    }
}
