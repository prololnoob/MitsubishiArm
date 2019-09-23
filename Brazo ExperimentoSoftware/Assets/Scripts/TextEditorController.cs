﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TextBox;
    public Text PosTextBox;

    int textSize = 1;
    int maxTextSize = 8;

    public enum commandLines {SAVE, LOAD, MOV, ROT, WHILE, WEND, OVRD, DEF,POS};
    public enum movParts {WAIST, SHOUDLER, ELBOW, TWIST, PITCH, ROLL};

    void Start()
    {
        TextBox.text ="";
        PosTextBox.text = "";

    }

    public bool WritePositions(GameObject arm){
        if(textSize > maxTextSize) return false;
        PosTextBox.text += "P"+textSize+"= "+arm.transform.position.ToString("F2")+arm.transform.eulerAngles.ToString("F2")+"\n";
        return true;
    }

    public void WriteCommands(commandLines order, GameObject mobile){
        if(TextBox.text.Length > 680) TextBox.text = "";
        TextBox.text += order.ToString() +mobile.transform.position.ToString("F2") + mobile.transform.eulerAngles.ToString("F2") + "\n";
    }
}