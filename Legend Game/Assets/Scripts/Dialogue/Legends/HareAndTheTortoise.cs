using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareAndTheTortoise : LegendTemplate
{
    public HareAndTheTortoise() {
        title = "The Hare and the Tortoise";
        paragraphList.Add("Tell me, do you like to live a very fast paced life, or do you prefer to take things slow?");
        List<string> firstAnswer = new List<string>();

        firstAnswer.Add("Aye. Swift to action, prideful of accomplishment. I can see it, you are akin to the Hare. Should you want to achieve a task, a race if you will, that you know you can accomplish with ease, would you see the task through in great haste, or would you put off the task until the last minute?");

        Answer fast = new Answer("Fast", firstAnswer, 0, 25, -5, 0, 10, 0, null, true);

        
    }
}
