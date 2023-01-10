using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Words : MonoBehaviour
{

    string[] afterlifeAnswers = {
    "It is certain that you will meet your afterlife",
    "It is decidedly so that you will find peace in the afterlife",
    "Without a doubt, you will be reunited with loved ones in the afterlife",
    "Yes definitely, the afterlife holds great things for you",
    "You may rely on it, your soul will find rest in the afterlife",
    "As I see it, yes, the afterlife is a journey worth taking",
    "Most likely, your time in the living world has prepared you for the afterlife",
    "Outlook good, you will find joy and understanding in the afterlife",
    "Yes, the afterlife is a place of beauty and love",
    "Signs point to yes, your spirit will soar in the afterlife",
    "Reply hazy try again, your understanding of the afterlife is incomplete",
    "Ask again later, the timing of your journey to the afterlife is not yet clear",
    "Better not tell you now, the afterlife is a mystery yet to be revealed",
    "Cannot predict now, the path to the afterlife is unpredictable",
    "Concentrate and ask again, to understand the afterlife, focus on the present",
    "Don't count on it, your actions in life will determine your path in the afterlife",
    "My reply is no, the afterlife is not the end, but a new beginning",
    "My sources say no, the afterlife is not a destination, but a journey",
    "Outlook not so good, heed the lessons of the living to prepare for the afterlife",
    "Very doubtful, the afterlife is not a thing to be doubted, but accepted."
};

   private void Awake() {
    Randomize();
    InvokeRepeating("Randomize", 0, 10);
  }

   private void Randomize()
    {
    var text = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    text.text = afterlifeAnswers[Random.Range(0, afterlifeAnswers.Length)];
    text.fontSize = 0.07f;
 
    }
}
