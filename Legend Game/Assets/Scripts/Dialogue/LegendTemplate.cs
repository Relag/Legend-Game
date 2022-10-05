using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LegendTemplate
{
    //Provide paragraphs and answers
    public string title;
    public List<string> paragraphList = new List<string>();
    public List<Answer> answerList = new List<Answer>();

    //Call when player clicks an answer
    public Answer giveAnswer(string answer) {
        foreach (Answer answers in answerList) {
            if (Equals(answer, answers)) {
                return answers;
            }
        }
        return null;
    }
}

public class Answer
{
    public string answer { get; set; }
    public List<string> paragraphs;
    public int commerce;
    public int military;
    public int religion;
    public bool theEnd;
    public LegendIcons iconUnlocked;

    public Answer(string answer, List<string> answerList, int commerce, int military, int religion, LegendIcons iconUnlocked = null, bool theEnd = true) {
        this.answer = answer;
        this.paragraphs = answerList;
        this.commerce = commerce;
        this.military = military;
        this.religion = religion;
        this.theEnd = theEnd;
        this.iconUnlocked = iconUnlocked;
    }
}




