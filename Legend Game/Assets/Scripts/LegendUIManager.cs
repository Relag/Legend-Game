using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LegendUIManager : MonoBehaviour
{

    public static LegendUIManager legendUIManager;

    [SerializeField]
    private TextMeshPro titleText;
    [SerializeField]
    private TextMeshPro storyText;
    [SerializeField]
    private GameObject choicePanel;

    LegendTemplate currentLegend;

    private void Awake() {
        if (legendUIManager != null) {
            Destroy(gameObject);
        }
        else {
            legendUIManager = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        currentLegend = DialogueManager.dialogueManager.getLegend();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoryTime() {
        DialogueManager.dialogueManager.getLegend();


    }
}
