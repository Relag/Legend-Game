using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DialogueManager : MonoBehaviour
{
    public static DialogueManager dialogueManager;

    [SerializeField]
    public List<LegendTemplate> unlockedLegends = new List<LegendTemplate>();
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
        unlockedLegends.Add(new TheKingAndHisMariners());
        unlockedLegends.Add(new HareAndTheTortoise());
    }

    //Shuffle LegendList and return a random legend to the player.
    public LegendTemplate getLegend() {
        if (unlockedLegends.Count > 0) {
            int index = Random.Range(0, unlockedLegends.Count);
            LegendTemplate returnLegend = unlockedLegends[index];
            unlockedLegends.Remove(unlockedLegends[index]);
            return returnLegend;
        }
        else {
            return new DefaultLegend();
        }
    }
}
