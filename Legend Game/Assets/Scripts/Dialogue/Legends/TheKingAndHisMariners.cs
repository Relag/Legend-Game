using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class TheKingAndHisMariners : LegendTemplate
{
    public TheKingAndHisMariners() {

        title = "The King and His Mariners";
        paragraphList.Add("Long ago there was a King. He was a kind man stalwart and true, but he was not content to sit on his throne. Instead, he decided to be a leader of his people and set out on a naval expedition.");
        
        paragraphList.Add("The seas were harsh, and soon a great storm rolled in. Despite their best efforts, the mariners could not tame these waves and the ship soon ran aground in a foreign land. The King led his men to shore, but now a decision had to be made.");

        List<string> firstAnswer = new List<string>();
        firstAnswer.Add("The King gathered the mariners and told them to quickly form hunting parties. The men made makeshift spears from the planks of driftwood and soon set off in search of game. " +
            "Hidden in the trees, the King spotted a great boar. He motioned to his party and they soon had the boar surrounded, with the beast none the wiser. What followed was swift and ruthless, and after the King and his mariners had a grand feast. " +
            "They lived this simple life until help came.");

        answerList.Add(new Answer("Search for Food", firstAnswer, 0, 15, 0, 0, 0, 0, null, true));

        List<string> secondAnswer = new List<string>();

        secondAnswer.Add("The King decided to search the grounds for any nearby settlements. The group happened upon a small village, and the King’s fineries and regal bearing were all that were needed to convince the denizens that he was a man of importance. " +
            "The town helped the King and his men, and in return the King showered them with gifts. Commerce and love flourish between his Kingdom and that town to this day.");
        answerList.Add(new Answer("Search for Civilization", secondAnswer, 15, 0, 0, 0, 0, 0, null, true));

        List<string> thirdAnswer = new List<string>();
        thirdAnswer.Add("The King knelt down and led his men in a group prayer. Each man gave themselves willingly to their God, and when the prayer was completed the clouds parted and the sun beckoned the men to follow. " +
            "The men found a rowboat, washed up on the shore and miraculously intact. They sent their finest navigator on this boat to find their Kingdom and return with aid. The King’s faith had yielded great results, and he soon returned home.");

        answerList.Add(new Answer("Search for Guidance", thirdAnswer, 0, 0, 15, 0, 0, 0, new Blacksmith(), true)); 
    }

}
