using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{
    public Config config;
    public bool safetyLock;
    public bool broken;
    public bool stuckBullet;
    public bool overheated;


    public float temperature;
    public float maxTemperature;
    

    [System.Serializable]
    public class Config {
        public string weaponName;

        public bool shootingOne;
        public bool shootingTwo;
        public bool shootingThree;
        public bool shootingAutomatic;

        public enum WeaponType { gun, revolver, rpg, weapon }
        public WeaponType weaponType;

        public float bulletSize;
    }
}
