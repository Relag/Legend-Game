using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    private List<LegendTemplate> legendTemplates;

    public LegendTemplate getLegend() {
        int index = Random.Range(0, legendTemplates.Count);
        return legendTemplates[index];

    }


}
