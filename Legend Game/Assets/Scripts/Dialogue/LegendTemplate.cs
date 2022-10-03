using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class LegendTemplate
{
    List<string> paragraphList;

    Dictionary<string, List<string>> answerList;

    public List<string> giveAnswer(string answer) {
        foreach (KeyValuePair<string, List<string>> answers in answerList) {
            if (Equals(answer, answers)) {
                return answers.Value;
            }
        }
        return null;
    }

}

