using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "Cards")]
[System.Serializable]
public abstract class Card : ScriptableObject
{
    public string cardName;
    public int id;
    public bool inDeck = false;
    public bool inHand = false;
    public bool inGrave = false;
    public static string[] elements = new string[] { "Earth", "Sky", "Fire", "Combat", "Ethereal", "Demon" };
    public string element;
    public static string[] types = new string[] { "Attack", "Spell", "Support", "Summon" };
    public string type;
    public static string[] rarities = new string[] { "Common", "Uncommon", "Rare", "Legendary", "Boss" };
    public string rarity;
    public int learnCost;
    public int playCost;
    public string cardText;
    public string flavorText;
    
    public void Cast()
    {
        inHand = false;
        inGrave = true;
    }
    
    public void GraveToHand()
    {
        inGrave = false;
        inHand = true;
    }

    public void Discard()
    {
        inHand = false;
        inGrave = true;
    }

    public void Mill()
    {
        inDeck = false;
        inGrave = true;
    }

}
