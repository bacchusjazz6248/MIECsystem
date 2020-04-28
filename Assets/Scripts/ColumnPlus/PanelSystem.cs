using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class PanelSystem : MonoBehaviour
{
    public InputField inputField;
    public Text text;
    public GameObject infoname_obj = null;

    void Start()
    {
        /*inputField = inputField.GetComponent<InputField> ();
        text = text.GetComponent<Text>();*/
    }
    
    /*public void InputText(){
        text.text = inputField.text;
    }*/

    public void Update()
    {
        StreamReader sr = new StreamReader("../InfoData.txt", Encoding.GetEncoding("Shift_JIS"));

        while (sr.Peek() != -1)
        {
            Text infoname = infoname_obj.GetComponent<Text> ();
            String str = sr.ReadLine();
            infoname.text = str;
        }
    }
}
