using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LegendIcons : MonoBehaviour
{
    [SerializeField]
    protected Sprite iconSprite;
    public Vector2 location;

    public int military { get; set; } 
    public int religion { get; }
    public int commerce { get; }
    public int foodGiven { get; }
    public int materialGiven { get; }
    public int knowledgeGiven { get; }
    public int foodRequired { get; }
    public int materialRequired { get; }
    public int knowledgeRequired { get; }

    public bool unlocked = false;

   public void unlock() {
        unlocked = true;
        //inform UI manager that icon is unlocked and should be shown.
    }

}
