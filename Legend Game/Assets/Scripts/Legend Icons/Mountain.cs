using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : LegendIcons
{
    public Mountain() {
        name = "Mountain";
        unlocked = true;
        foodRequired = 5;
        materialRequired = 15;
        knowledgeRequired = 10;

        commerce = 0;
        military = 10;
        religion = 10;

        knowledgeGiven = 10;
        foodGiven = 0;
        materialGiven = 25;
    }

    public override void BeingPurchased() {
       
    }
}
