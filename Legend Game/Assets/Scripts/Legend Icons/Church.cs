using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church : LegendIcons
{
    public Church() {
        name = "Church";
        unlocked = true;
        foodRequired = 10;
        materialRequired = 20;
        knowledgeRequired = 10;

        commerce = 5;
        military = 0;
        religion = 20;

        knowledgeGiven = 10;
        foodGiven = 0;
        materialGiven = 0;
    }

    public override void BeingPurchased() {

    }
}
