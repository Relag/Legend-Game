using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LegendUIManager : MonoBehaviour
{

    public static LegendUIManager legendUIManager;

    [SerializeField]
    private TextMeshProUGUI titleText;
    [SerializeField]
    private TextMeshProUGUI storyText;
    [SerializeField]
    private GameObject choicePanel;
    [SerializeField]
    private Button button;

    private List<Button> buttonList;

    private int paragraphNumber;

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
        StoryTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoryTime() {
        paragraphNumber = 0;
        currentLegend = DialogueManager.dialogueManager.getLegend();
        titleText.text = currentLegend.title;
        storyText.text = currentLegend.paragraphList[paragraphNumber];

    

        GenerateButtons();
    }

    public void GenerateButtons() {
        for (int i = 0; i < currentLegend.answerList.Count; i++) {
            Button loop = Instantiate(button);
            loop.transform.parent = choicePanel.transform;
            TextMeshProUGUI text = loop.GetComponentInChildren<TextMeshProUGUI>();
            text.text = currentLegend.answerList[i].answer;
            loop.onClick.AddListener(Answer);
        }
    }

    public void Answer() {
        GameObject thisButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        TextMeshProUGUI text = thisButton.GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log(text.text);
        foreach (Answer answer in currentLegend.answerList) {
            if (Equals(text.text, answer.answer)) {
                for (int i = 0; i < answer.paragraphs.Count; i++)
                    currentLegend.paragraphList.Add(answer.paragraphs[i]);
            }
        }
    }

    public void NextParagraph() {
        if (paragraphNumber <= currentLegend.paragraphList.Count - 2 ) {
            paragraphNumber++;
            storyText.text = currentLegend.paragraphList[paragraphNumber];
        }
    }

    public void PreviousParagraph() {
        if (paragraphNumber > 0) {
            paragraphNumber--;
            storyText.text = currentLegend.paragraphList[paragraphNumber];
        }
    }
}
