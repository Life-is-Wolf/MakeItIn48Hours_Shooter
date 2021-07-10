using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{
    public string weaponName;

    public bool shootingOne;
    public bool shootingTwo;
    public bool shootingThree;
    public bool shootingAutomatic;

    public enum WeaponType { gun, revolver, rpg, weapon}
    public WeaponType weaponType;

    public float bulletSize;
    public float mainspringPower;
}
