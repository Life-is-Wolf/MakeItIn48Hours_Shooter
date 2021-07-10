using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WeaponShopManager : MonoBehaviour
{
    private List<BulletData> bullets = new List<BulletData>();
    [SerializeField]
    public Vector2 bulletSize; // максимальный размер пули (в мм)
    [SerializeField]
    public float maxBulletCount; // максимальное количисто пуль

    public void Start()
    {
        Init();
    }

    public void Init()
    {

    }

    public void AddBulets(List<BulletData> _bullets)
    {
        foreach (var item in _bullets)
        {
            bullets.Add(item);
        }
    }
    public void AddBulet(BulletData _bullet)
    {
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
