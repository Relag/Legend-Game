using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultLegend : LegendTemplate
{
    public DefaultLegend() {
        title = "Be on they way";
        paragraphList.Add("There are no stories left to tell.");

        answerList.Add(new Answer("Leave", null, 0, 0, 0, 0, 0, 0, null, true));
    }
}
