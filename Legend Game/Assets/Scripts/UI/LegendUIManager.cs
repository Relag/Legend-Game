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
    private GameObject endPanel;
    [SerializeField]
    private Button button;

    [SerializeField]
    private Button endButton;

    [SerializeField]
    private Button nextTurnButton;

    [SerializeField]
    private TextMeshProUGUI statText;

    private List<Button> buttonList;

    private int paragraphNumber;

    LegendTemplate currentLegend;

    private int totalMilitary = 0;
    private int totalCommerce = 0;
    private int totalReligion = 0;
    private int totalFood = 0;
    private int totalKnowledge = 0;
    private int totalMaterials = 0;

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
          
    }

    //Sets Legend UI to true, sets up paragraphs and answers.
    public void StoryTime() {
        endPanel.SetActive(false);
        choicePanel.SetActive(true);
        foreach (Transform child in choicePanel.transform)
            Destroy(child.gameObject);
        nextTurnButton.gameObject.SetActive(false);
        

        paragraphNumber = 0;
        currentLegend = DialogueManager.dialogueManager.getLegend();
        titleText.text = currentLegend.title;
        storyText.text = currentLegend.paragraphList[paragraphNumber];

        choicePanel.GetComponent<VerticalLayoutGroup>().enabled = true;

        GenerateButtons();
    }

    //Draw from the answer list to create buttons.
    public void GenerateButtons() {
        foreach (Transform child in choicePanel.transform)
            Destroy(child.gameObject);
        for (int i = 0; i < currentLegend.answerList.Count; i++) {
            Button loop = Instantiate(button);
            loop.transform.parent = choicePanel.transform;
            TextMeshProUGUI text = loop.GetComponentInChildren<TextMeshProUGUI>();
            text.text = currentLegend.answerList[i].answer;
            loop.onClick.AddListener(Answer);
        }
    }

    //Calls when the player chooses an answer. Run through the answers and ensure the button text matches the answer.
    //Add the answer paragraphs to the paragraph list.
    //Unlock legendicons and add up stats.
    public void Answer() {
        GameObject thisButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        TextMeshProUGUI text = thisButton.GetComponentInChildren<TextMeshProUGUI>();

        foreach (Answer answer in currentLegend.answerList) {
            if (Equals(text.text, answer.answer)) {
                for (int i = 0; i < answer.paragraphs.Count; i++)
                    currentLegend.paragraphList.Add(answer.paragraphs[i]);
                if (answer.iconUnlocked is LegendIcons) {
                    statText.text += answer.iconUnlocked.name + " Unlocked";
                }
                //End the story and draw the stats gained. Add paragraphs branching from answer to the paragraph list. Reset currencies.
                if (answer.theEnd) {
                    choicePanel.SetActive(false);
                    endPanel.SetActive(true);
                    UpdateAnswerStats(answer);
                    statText.text = totalMilitary + " + Military\n" + totalCommerce + " + Commerce\n" + totalReligion + " + Religion\n" + totalFood + " + Food\n" + totalMaterials + " + Materials\n" + totalKnowledge + " + Knowledge";
                } else {
                    foreach (string paragraph in answer.paragraphs) {
                        currentLegend.paragraphList.Add(paragraph);
                    }
                    currentLegend.answerList.Clear();
                    foreach (Answer nextAnswer in answer.nextAnswers) {
                        currentLegend.answerList.Add(nextAnswer);
                    }
                    GenerateButtons();
                }
                NextParagraph();
            }
        }
    }

    private void UpdateAnswerStats(Answer answer) {
        totalMilitary += answer.military;
        totalCommerce += answer.commerce;
        totalReligion = +answer.religion;
        totalMaterials = answer.materials;
        totalKnowledge += answer.knowledge;
        totalFood += answer.food;
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

    public void BeginningTime() {
        currentLegend = new Beginning();

        endPanel.SetActive(false);
        choicePanel.SetActive(true);

        paragraphNumber = 0;
        titleText.text = currentLegend.title;
        storyText.text = currentLegend.paragraphList[paragraphNumber];

        choicePanel.GetComponent<VerticalLayoutGroup>().enabled = true;
        GenerateButtons();
    }

    public void EndingTime(LegendTemplate ending) {

        endPanel.SetActive(false);
        choicePanel.SetActive(true);

        foreach (Transform child in choicePanel.transform)
            Destroy(child.gameObject);

        paragraphNumber = 0;
        currentLegend = ending;
        titleText.text = ending.title;
        storyText.text = ending.paragraphList[paragraphNumber];
    }
}
