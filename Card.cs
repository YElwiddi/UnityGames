﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class Card : ScriptableObject
{
    public string cardname;
    public Sprite artwork;
    public string attack;
    public string specialeffect;
    public bool Selected;
}
