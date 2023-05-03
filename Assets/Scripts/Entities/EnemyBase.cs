using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    int Shield;
    int ShieldMax;

    int Health;
    int HealthMax;

    int BaseDamage;

    List<StatusAilment> StatusAilmentsList;
    WeaponBase.TypeOfDamage ShieldType;
    List<WeaponBase.TypeOfDamage> ShieldWeakness;

    public enum EnemyType
    {
        Normal = 0,
        Elite,
        Boss,
        Total
    }

    public enum EnemyMovementType
    {
        Normal = 0,
        Flying,
        Worm,
        Total
    }

    public enum EnemyVariation
    {
        Total
    }

    EnemyType eEnemyType;
    EnemyMovementType eEnemyMovementType;
    EnemyVariation eEnemyVariation;
}
