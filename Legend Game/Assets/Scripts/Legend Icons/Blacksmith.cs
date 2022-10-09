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

    public override void BeingPurchased() {
        for (int i = 0; i < TownManager.townManager.purchaseList.Count; i++)
            if (TownManager.townManager.purchaseList[i].name == "Mine") {
                    commerce = 15;
                    military = 30;
                    foodGiven = 15;   
            }
        GameObject blacksmith = GameObject.Find("Blacksmith");
        blacksmith.GetComponent<SpriteRenderer>().enabled = true;
        DialogueManager.dialogueManager.unlockedLegends.Add(new TheYoungBlacksmith());
    }

}
