using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardData : ScriptableObject
{
    [SerializeField]
    private string cardName, element, type, rarity;
    [SerializeField]
    private int id, learnCost, playCost;
    [SerializeField]
    private string cardText, flavorText;
    
    public string CardName
    {
        get { return cardName; }
    }
    public string Element
    {
        get { return element; }
    }
    public string Type
    {
        get { return type; }
    }
    public string Rarity
    {
        get { return rarity; }
    }
    public int Id
    {
        get { return id; }
    }
    public int LearnCost
    {
        get { return learnCost; }
    }
    public int PlayCost
    {
        get { return playCost; }
    }

    public string CardText
    {
        get { return cardText; }
    }
    public string FlavorText
    {
        get { return flavorText; }
    }
}
