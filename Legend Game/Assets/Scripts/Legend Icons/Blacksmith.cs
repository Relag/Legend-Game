using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : LegendIcons
{
    
    public Blacksmith () {
        name = "Blacksmith";
        unlocked = true;
        foodRequired = 0;
        materialRequired = 10;
        knowledgeRequired = 10;

        commerce = 10;
        military = 20;
        foodGiven = 10;

        knowledgeGiven = 0;
        religion = 0;
        materialGiven = 0;
    }
}
