using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DialogueManager : MonoBehaviour
{
    public static DialogueManager dialogueManager;

    [SerializeField]
    private List<LegendTemplate> unlockedLegends = new List<LegendTemplate>();
    private List<LegendTemplate> lockedLegends = new List<LegendTemplate>();

    private void Awake() {
        if (dialogueManager != null) {
            Destroy(gameObject);
        }
        else {
            dialogueManager = this;
        }
    }

    public void Start() {
        
    }

    //Shuffle LegendList and return a random legend to the player.
    public LegendTemplate getLegend() {
        unlockedLegends.Add(new TheKingAndHisMariners());
        int index = Random.Range(0, unlockedLegends.Count);
        return unlockedLegends[index];
    }
    
}
