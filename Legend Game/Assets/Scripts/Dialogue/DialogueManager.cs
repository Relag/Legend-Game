using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DialogueManager : MonoBehaviour
{
    public static DialogueManager dialogueManager;

    private void Awake() {
        if (dialogueManager != null) {
            Destroy(gameObject);
        } else {
            dialogueManager = this;
        }

    }

    [SerializeField]
    private List<LegendTemplate> legendTemplates;

    public LegendTemplate getLegend() {
        int index = Random.Range(0, legendTemplates.Count);
        return legendTemplates[index];
    }
    
}
