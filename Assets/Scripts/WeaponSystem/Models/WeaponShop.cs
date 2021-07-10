using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShop : MonoBehaviour
{
    private List<BulletData> bullets = new List<BulletData>();
    [SerializeField]
    private Vector2 bulletSize; // максимальный размер пули (в мм)
    [SerializeField]
    private float maxBulletCount; // максимальное количисто пуль

    public uint networkId;
    public void Start()
    {
        Init();
    }

    public void Init()
    {

    }
    public void AddBulets(List<BulletData> _bullets) { 
        foreach (var item in _bullets) 
        {
            bullets.Add(item); 
        }
    }
    public void AddBulet(BulletData _bullet) {
        bullets.Add(_bullet);
    }

    public BulletData UseBullet()
    {
        int allBulletsCount = bullets.Count;
        var bullet = bullets[allBulletsCount];
        bullets.RemoveAt(allBulletsCount);
        return bullet;
    }    
}
