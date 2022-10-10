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

//Answers for every story. Every answer must have a list of succeeding paragraphs and the stats gained.
//If not the end of the story and no stats are gained simply pass nothing.
//Upon reaching the end of the story all arguments must be passed and the "theEnd" bool set to true.
public class Answer
{
    public string answer { get; set; }
    public List<string> paragraphs;
    public int commerce;
    public int military;
    public int religion;
    public int food;
    public int materials;
    public int knowledge;
    public bool theEnd;
    public LegendIcons iconUnlocked;
    public List<Answer> nextAnswers = new List<Answer>();

    public Answer(string answer, List<string> answerList, int commerce = 0, int military = 0, int religion = 0, int food = 0, int material = 0, int knowledge = 0, LegendIcons iconUnlocked = null, bool theEnd = false) {
        this.answer = answer;
        this.paragraphs = answerList;
        this.commerce = commerce;
        this.military = military;
        this.religion = religion;
        this.knowledge = knowledge;
        this.food = food;
        this.materials = material;
        this.theEnd = theEnd;
        this.iconUnlocked = iconUnlocked;
    }
}




