using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemLog : MonoBehaviour
{
    public WeaponManager manager; 
    private bool open;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2)) open = !open;
    }
    void OnGUI()
    {
        if (open)
        {
            GUILayout.BeginVertical();
            GUILayout.TextArea("Weapon System log`s");
            GUILayout.Space(3);
            GUILayout.TextArea("This Weapon Data");
            GUILayout.TextArea("This Weapon -> " + manager.config.weaponName);
            GUILayout.TextArea("this temperature -> " + manager.temperature);
            GUILayout.TextArea("this is broken -> " + manager.broken);
            GUILayout.TextArea("this is overheated -> " + manager.overheated);
            GUILayout.TextArea("this is safetyLock -> " + manager.safetyLock);
            GUILayout.TextArea("this is stuckBullet -> " + manager.stuckBullet);

            GUILayout.TextArea("This Weapon Config");
            GUILayout.TextArea("weaponName -> " + manager.config.weaponName);
            GUILayout.TextArea("bulletSize -> " + manager.config.bulletSize);

            GUILayout.TextArea("shootingOne -> " + manager.config.shootingOne);
            GUILayout.TextArea("shootingTwo -> " + manager.config.shootingTwo);
            GUILayout.TextArea("shootingThree -> " + manager.config.shootingThree);
            GUILayout.TextArea("shootingAutomatic -> " + manager.config.shootingAutomatic);

            GUILayout.TextArea("weaponType -> " + manager.config.weaponType);
            GUILayout.EndVertical();
        }    
        
    }
}
