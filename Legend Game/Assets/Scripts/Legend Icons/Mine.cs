using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : LegendIcons
{
    public Mine() {
        name = "Mine";
        unlocked = true;
        foodRequired = 20;
        materialRequired = 15;
        knowledgeRequired = 15;

        commerce = 20;
        military = 20;
        religion = 0;

        knowledgeGiven = 0;
        foodGiven = 10;
        materialGiven = 25;
    }

    public override void BeingPurchased() {
        for (int i = 0; i < TownManager.townManager.purchaseList.Count; i++)
            if (TownManager.townManager.purchaseList[i].name == "Mountain") {
                commerce = 25;
                military = 30;
                materialGiven = 30;
                religion = 5;
            }
        GameObject blacksmith = GameObject.Find("Mine");
        blacksmith.GetComponent<SpriteRenderer>().enabled = true;
    }
}
