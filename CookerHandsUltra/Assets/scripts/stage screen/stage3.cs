﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stage3 : MonoBehaviour {
    public int inputState;
    public string myText;
    // Use this for initialization
    void Start () {
        myText = "We ran our scene.";
        inputState = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (inputState == 0)
        {
            myText = "Stage 3: The Cheese Grating\n\nYou become impressed on the progress you have made; however, the health inspector is growing more impatient and demands the food to be done soon.\nYou prepare your cheese until you see rodents crawling around the area.\nYou roll up your sleeves and decide to teach the rats who's the real boss in this kitchen.\n\n ";
            myText += "Press X to Continue.";
        }
        GetComponent<Text>().text = myText;
    }
}
