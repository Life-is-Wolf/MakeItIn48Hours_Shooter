using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShop : MonoBehaviour
{
    public List<BulletData> bullets = new List<BulletData>();
    public float maxBulletSize; // максимальный размер пули (в мм)
    public float maxBulletCount; // максимальное количисто пуль
}
