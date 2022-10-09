using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    List<LegendIcons> legendIcondList;
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
        Blacksmith blacksmith = new Blacksmith();
        legendIcondList.Add(blacksmith);
        turnCount = 1;
    }

    public void NextTurn() {
        if (turnCount < 5) {
            turnCount++;
            LegendUIManager.legendUIManager.StoryTime();
            TownManager.townManager.startNextTurn();
        }
    }
}
