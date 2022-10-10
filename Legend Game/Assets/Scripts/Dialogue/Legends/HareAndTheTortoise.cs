using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareAndTheTortoise : LegendTemplate
{
    public HareAndTheTortoise() {
        title = "The Hare and the Tortoise";
        paragraphList.Add("Tell me, do you like to live a very fast paced life, or do you prefer to take things slow?");

        List<string> answerFast = new List<string>();
        answerFast.Add("Aye. Swift to action, prideful of accomplishment. I can see it, you are akin to the Hare. Should you want to achieve a task, a race if you will, that you know you can accomplish with ease, would you see the task through in great haste, or would you put off the task until the last minute?");

        List<string> answerProcrastinate = new List<string>();
        answerProcrastinate.Add("A common yet human habit. While not always bad, never underestimate your circumstance, and especially not your competition...or enemy. You would be wiser to avoid this as much as you can so you do not lose your race.");

        List<string> answerCompleteTask = new List<string>();
        answerCompleteTask.Add("Such is the logical choice. There is much importance of being able to recognize one's strength and capabilities and using them to one's advantage. Otherwise, if you don't use it, you will lose it. Win the race, don't slack off.");

        Answer procrastinate = new Answer("Procrastinate", answerProcrastinate, 0, 0, 10, 0, 0, 10, null, true);
        Answer completeTask = new Answer("Complete Task", answerCompleteTask, 10, 5, 0, 0, 10, 0, null, true);
        Answer fast = new Answer("Fast", answerFast);
        fast.nextAnswers.Add(procrastinate);
        fast.nextAnswers.Add(completeTask);

        List<string> answerSlow = new List<string>();
        answerSlow.Add("Aye. Steady and resilient, strong and fortified. I can see it, you are akin to the Tortoise. You may encounter great struggles and many setbacks compared to others. Think of a race, my little Tortoise friend. Do you take the risk for failure with all of the struggles you may face, or do you remain within the safety of your shell?");

        List<string> answerTakeRisk = new List<string>();
        answerTakeRisk.Add("Risk taking is important and can help you overcome many difficulties with amazing pay offs. You just need to be honest about what it is you are capable of and act within your means while strategically exceeding it.");

        List<string> answerPlaySafe = new List<string>();
        answerPlaySafe.Add("You will remain a victim of your own environment if you do not reach out beyond yourself. Life is dangerous, unknown, and with many threats out to get you. Fear not, and do not hide within your shell.");

        Answer takeRisk = new Answer("Take a Risk", answerTakeRisk, 10, 0, 0, 15, 0, 0, null, true);
        Answer playSafe = new Answer("Play it Safe", answerPlaySafe, 0, 10, 0, 0, 0, 0, null, true);
        Answer slow = new Answer("Slow", answerSlow);

        slow.nextAnswers.Add(takeRisk);
        slow.nextAnswers.Add(playSafe);

        answerList.Add(fast);
        answerList.Add(slow);
    }
}
