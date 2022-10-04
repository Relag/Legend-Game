using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LegendUIManager : MonoBehaviour
{

    public static LegendUIManager legendUIManager;

    [SerializeField]
    private TextMeshProUGUI titleText;
    [SerializeField]
    private TextMeshProUGUI storyText;
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
        titleText.text = currentLegend.title;
        storyText.text = currentLegend.paragraphList[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoryTime() {
        DialogueManager.dialogueManager.getLegend();


    }

    public void GenerateButtons() {

    }
}
