using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skul.Data
{
    public enum ItemRate
    {
        Normal,
        Rare,
        Unique,
        Legend
    }
    public abstract class ItemData : ScriptableObject
    {
        public int id;
        public string Name;
        public Sprite Icon;
        public ItemRate rate;
        public string description;
        public string abilityDescription;
    }
}
