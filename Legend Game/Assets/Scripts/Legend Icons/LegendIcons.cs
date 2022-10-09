using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LegendIcons : MonoBehaviour
{
    [SerializeField]
    protected Sprite iconSprite;
    public Vector2 location;

    

    public int military { get; set; } 
    public int religion { get; set; }
    public int commerce { get; set; }
    public int foodGiven { get; set; }
    public int materialGiven { get; set; }
    public int knowledgeGiven { get; set; }
    public int foodRequired { get; set; }
    public int materialRequired { get; set; }
    public int knowledgeRequired { get; set; }
    public string name;

    public bool unlocked = false;
    public bool purchased = false;

    public bool shouldBeShown() {
        if (unlocked && !purchased)
            return true;
        else
            return false;
    }

    public virtual void BeingPurchased() {

    }
}


