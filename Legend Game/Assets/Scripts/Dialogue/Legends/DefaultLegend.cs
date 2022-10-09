using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultLegend : LegendTemplate
{
    public DefaultLegend() {
        title = "Be on thy way";
        paragraphList.Add("There are no stories left to tell.");
        List<string> answer = new List<string>();
        answer.Add("Perhaps next time.");
        answerList.Add(new Answer("Leave",answer, 0, 0, 0, 0, 0, 0, null, true));
    }
}
