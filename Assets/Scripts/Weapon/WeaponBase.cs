using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    public enum TypeOfDamage
    {
        Physical = 0,
        Fire,
        Ice,
        Lightning,
        Natural,
        Dark,
        Light,
        TotalTypes
    }

    public enum Stats
    {
        AttackFlat,
        AttackPercentage,

        MaxHealth,

        IncreasedAfflictions,

        DefenceFlat,
        DefencePercentage,
        FireDefencePercentage,
        IceDefencePercentage,
        NaturalDefencePercentage,
        LightningDefencePercentage,
        PhysicalDefencePercentage,
        DarkDefencePercentage,
        LightDefencePercentage,

        ResistancePercentage,
        FireResistancePercentage,
        IceResistancePercentage,
        NaturalResistancePercentage,
        LightningResistancePercentage,
        PhysicalResistancePercentage,
        DarkResistancePercentage,
        LightResistancePercentage,

        Total
    }

    TypeOfDamage eTypeOfDamage;
    int BaseDamage;

    int Proficiency;
    int ProficiencyOwned;
    int ProficiencyExp;
    int ProficiencyRequired;
    // Tree

    enum WeaponType
    {
        Swords = 0,
        Bow,
        Hammer,
        TotalTypes
    }

    WeaponType eWeaponType;

    int Level;

    // BonusStats

    public int GetDamage()
    {
        int returnDamage;

        returnDamage = BaseDamage;

        return returnDamage;
    }
}
