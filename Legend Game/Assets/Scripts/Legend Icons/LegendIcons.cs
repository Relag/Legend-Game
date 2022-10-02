using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LegendIcons : MonoBehaviour
{
    [SerializeField]
    protected Sprite iconSprite;
    public Vector2 location;

    protected int military { get; } 
    protected int religion { get; }
    protected int commerce { get; }
    protected int food { get; }
    protected int material { get; }
    protected int knowledge { get; }

   
}
