using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    List<WeaponBase> WeaponList = new List<WeaponBase>();
    List<EquipmentBase> EquipmentList = new List<EquipmentBase>();
    List<StatusAilment> StatusAilmentsList = new List<StatusAilment>();

    int HealthMax;
    int Health;

    List<int> Resistances = new List<int>();
    List<int> Defences = new List<int>();

    int CurrentWeapon;

    private void Awake()
    {
        HealthMax = 50;
        Health = HealthMax;
        CurrentWeapon = 0;
    }

    private void Reset()
    {
        Health = HealthMax;
    }

    private void Update()
    {
        // Weapon Switching
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (WeaponList[0] != null)
                CurrentWeapon = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (WeaponList[1] != null)
                CurrentWeapon = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (WeaponList[2] != null)
                CurrentWeapon = 2;
        }

        // Status Ailment Update
        for (int i = 0; i < StatusAilmentsList.Count; i++)
        {
            StatusAilmentsList[i].UpdateAilment();
        }
    }
}
