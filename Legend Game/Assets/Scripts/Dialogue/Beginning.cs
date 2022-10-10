using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beginning : LegendTemplate
{
    public Beginning() {
        title = "The Beginning";
        paragraphList.Add("The Calamity took everything from everyone. Driven from their homes and families they were left only with the legends I could tell. Hopefully that will be enough to get them through.");
        List<string> answer = new List<string>();
        answer.Add("Now, to the village.");
        answerList.Add(new Answer("Begin", answer, 0, 0, 0, 0, 0, 0, null, true));
    }

}
