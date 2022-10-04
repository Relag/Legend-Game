using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DialogueManager : MonoBehaviour
{
    public static DialogueManager dialogueManager;

    [SerializeField]
    private List<LegendTemplate> legendTemplates = new List<LegendTemplate>();

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



    public LegendTemplate getLegend() {
        legendTemplates.Add(new TheKingAndHisMariners());
        int index = Random.Range(0, legendTemplates.Count);
        return legendTemplates[index];
    }
    
}
