using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemAddBullets : MonoBehaviour
{
    public WeaponShopManager manager;
    public int _gunpowder;
    public bool _empty;
    public Vector2 _size;
    public GameObject _obj;
    // Start is called before the first frame update
    void Start()
    {
        AddAllBullets();
    }

    // Update is called once per frame
    void AddAllBullets()
    {
        for (int x =0; x> manager.maxBulletCount; x++)
        {
            manager.AddBulet(new BulletData { empty = _empty, gunpowder = _gunpowder, size = _size, obj = _obj } );
        }
    }
}
