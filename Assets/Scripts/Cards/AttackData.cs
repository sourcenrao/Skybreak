using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAttackData", menuName = "Attack")]
public class AttackData : CardData
{
    [SerializeField]
    private int damage1;
    [SerializeField]
    private int damage2;
    [SerializeField]
    private string damageType1 = "Combat";
    [SerializeField]
    private string damageType2 = null;
    [SerializeField]
    private int multiplier1, multiplier2, amplifier1, amplifier2;

    public int Damage1
    {
        get { return damage1; }
    }
    public int Damage2
    {
        get { return damage2; }
    }
    public string DamageType1
    {
        get { return damageType1; }
    }
    public string DamageType2
    {
        get { return damageType2; }
    }
    public int Multiplier1
    {
        get { return multiplier1; }
    }
    public int Multiplier2
    {
        get { return multiplier2; }
    }
    public int Amplifier1
    {
        get { return amplifier1; }
    }
    public int Amplifier2
    {
        get { return amplifier2; }
    }


}
