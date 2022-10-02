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
    public int food { get; }
    public int material { get; }
    public int knowledge { get; }

   
}
