using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    List<LegendIcons> legendIconList;
    public int turnCount;

    private void Awake() {
        if (gameManager != null) {
            Destroy(gameObject);
        }
        else {
            gameManager = this;
        }
    }
    

   //Blacksmith blacksmith;
    // Start is called before the first frame update
    void Start()
    {
        legendIconList.Add(new Blacksmith());
        turnCount = 1;
        LegendUIManager.legendUIManager.StoryTime();
    }

    public void NextTurn() {
        if (turnCount < 5) {
            turnCount++;
            TownManager.townManager.startNextTurn();
            LegendUIManager.legendUIManager.StoryTime();   
        }
        else {
            if (TownManager.townManager.MilitaryEnding() && TownManager.townManager.CommerceEnding() && TownManager.townManager.ReligionEnding())
                LegendUIManager.legendUIManager.EndingTime(new GoodEnding());
            else if (TownManager.townManager.MilitaryEnding() && TownManager.townManager.CommerceEnding())
                LegendUIManager.legendUIManager.EndingTime(new MilitaryCommerceEnding());
            else if (TownManager.townManager.CommerceEnding() && TownManager.townManager.ReligionEnding())
                LegendUIManager.legendUIManager.EndingTime(new CommerceReligionEnding());
            else if (TownManager.townManager.MilitaryEnding() && TownManager.townManager.ReligionEnding())
                LegendUIManager.legendUIManager.EndingTime(new MilitaryReligionEnding());
            else if (TownManager.townManager.MilitaryEnding())
                LegendUIManager.legendUIManager.EndingTime(new MilittaryEnding());
            else if (TownManager.townManager.CommerceEnding())
                LegendUIManager.legendUIManager.EndingTime(new CommerceEnding());
            else if (TownManager.townManager.ReligionEnding())
                LegendUIManager.legendUIManager.EndingTime(new ReligionEnding());
            else
                LegendUIManager.legendUIManager.EndingTime(new BadEnding());
        }
    }
}
