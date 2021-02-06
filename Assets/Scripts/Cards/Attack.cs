using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : Card
{
    public int damage1;
    public int damage2;
    public int damageType2;
    public int multiplier1;
    public int multiplier2;
    public int amplifier1;
    public int amplifier2;

    public abstract void Target();

}
