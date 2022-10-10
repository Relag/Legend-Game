using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : LegendIcons
{
    public Market() {
        name = "Market";
        unlocked = true;
        foodRequired = 10;
        materialRequired = 5    ;
        knowledgeRequired = 5;

        commerce = 10;
        military = 0;
        religion = 5;

        knowledgeGiven = 10;
        foodGiven = 0;
        materialGiven = 5;
    }

    public override void BeingPurchased() {

    }
}
