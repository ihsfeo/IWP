using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusAilment : MonoBehaviour
{
    WeaponBase.TypeOfDamage TypeOfAilment;
    int Level;
    int Adv;
    int AdvNeeded;
    
    public void IncreaseAdv(int amount)
    {
        if (Level == 3)
            return;
        Adv += amount;
    }

    public virtual bool UpdateAilment()
    {
        if (Adv <= 0 && Level == 1)
            return false;
        return true;
    }
}
