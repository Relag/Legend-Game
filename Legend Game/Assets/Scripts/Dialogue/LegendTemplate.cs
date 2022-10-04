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
    List<string> answerList;
    int commerce;
    int military;
    int religion;
    bool theEnd;

    public Answer(string answer, List<string> answerList, int commerce, int military, int religion, LegendIcons iconUnlocked = null, bool theEnd = true) {
        this.answer = answer;
        this.answerList = answerList;
        this.commerce = commerce;
        this.military = military;
        this.religion = religion;
        this.theEnd = theEnd;
    }
}




