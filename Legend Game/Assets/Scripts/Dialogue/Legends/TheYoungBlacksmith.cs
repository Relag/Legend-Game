using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheYoungBlacksmith : LegendTemplate
{
    public TheYoungBlacksmith() {
        title = "The Young Blacksmith";

        paragraphList.Add("She worked the furnace diligently, day in, day out, to support her ailing father. Though times were tough, her father had taught her everything there was to know about smithing. So, she laboured on.");
        paragraphList.Add("One night, after the smithy had closed and her father had been put to bed, a hooded man and a large entourage entered. The blacksmith knelt as the man removed his hood, revealing himself to be the young Prince of the realm.");
        paragraphList.Add("The Prince motioned for the blacksmith to stand, and reluctantly she did. The Prince relayed that his father was ill, much like hers, and that he would soon be King. As a new ascension to the throne, the prince needed a symbol to mark his dominion. He truseted the blacksmith to craft such a symbol.");
        paragraphList.Add("When the prince left, the young blacksmith was left shaken, and unsure how to handle such a momentous task. Eventually she settled and set to work. For the soon to be King, she crafted...");

        List<string> firstAnswer = new List<string>();
        firstAnswer.Add("When the Prince returned, the smith knelt down and presented the finest sword they had ever crafted. A blade that could cut stone and a pommel that melded with the palm, becoming as essential to the owner as their own hand.");
        firstAnswer.Add("With this sword the prince led his army to victory after victory. The prince’s legions cut a bloody swath through the countryside as he lay siege to the surrounding duchies and kingdoms. The young smith lived a long life dedicated to her craft, though she occasionally wondered if she was partly to blame for the bloodshed that followed.");

        answerList.Add(new Answer("A Sword of the Highest Calibre", firstAnswer, 0, 25, -5, 0, 10, 0, null, true));

        List<string> secondAnswer = new List<string>();
        secondAnswer.Add("When the Prince returned, the smith knelt down and presented a dagger encrusted with the finest jewels the realm had to offer. The dagger was sharp and deadly, while the jewels shone with a brilliance seldom seen by common folk.");
        secondAnswer.Add("The dagger lay in the prince’s robeside sheath, a secret to all but his closest confidants. In the daylight hours the prince and his diplomats negotiated dealings of commerce and trade. These seldom failed, as the prince had a preternatural knack for such negotiations; however, should worse come to worst, the prince knew he had a backup just on the underside of his robe.");

        answerList.Add(new Answer("A Jewel Encrusted Dagger", secondAnswer, 10, 10, 0, 0, 0, 0, null, true));

        List<string> thirdAnswer = new List<string>();
        thirdAnswer.Add("When the Prince returned, the smith knelt down and presented a fishing pole. One finely made to be sure, but a humble fishing pole nonetheless.The entourage were aghast that such an offering would be made, but much to everyone’s surprise, most of all the smith’s, the prince knelt down and lifted the pole from her hands.");
        thirdAnswer.Add("Standing, the Prince studied his newly received gift for a moment. Then, handling it with great care, left the smithy to return to his castle. Dumbfounded, the smithy continued kneeling for a moment before raising to tend to her ailing father.");
        thirdAnswer.Add("The kingdom entered a golden era. Food was abundant and the pursuit of knowledge and free-thinking abound. The Prince did not have an easy task before him, but when he felt like he had lost control he remembered the young smith, and her offering, and somehow he made things work in the end.");
        thirdAnswer.Add("Although her name never graced any history books, the smith lived the rest of her life content that she had helped her liege and her kingdom.");

        answerList.Add(new Answer("A Fishing Rod", thirdAnswer, 10, 10, 10, 0, 0, 10, null, true));

        List<string> fourthAnswer = new List<string>();
        fourthAnswer.Add("When the Prince returned, the smith knelt down and presented several denominations of coins with the Prince’s visage inscribed upon them. Shining gold, silver, and bronze each reflecting the soon to be king’s likeness back towards him.");
        fourthAnswer.Add("The coins were replicated and distributed far and wide. Soon, the coins became an international standard for currency, and not a person from sea to sea did not know at least the side profile of this new king.");
        fourthAnswer.Add("The blacksmith continued her life of smithing, and every time she exchanged goods for coin, or coin for goods, she wondered if she would get the recognition she deserved.");

        answerList.Add(new Answer("Coins Adourned with His Highness' Likeness", fourthAnswer, 0, 25, 0, 0, 0, 0, null, true));
    }
}
