using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class InputSystem : MonoBehaviour {
    
    public InputField inputField;
    public Text text;
    private int i = 0;

    void Start () {
        inputField = inputField.GetComponent<InputField> ();
        text = text.GetComponent<Text>();
    }

    public void InputText(){
        text.text = inputField.text;
    }

    public void OnClickRegistration()
    {
        if (i == 0)
        {
            StreamWriter sw = new StreamWriter("../InfoData.txt",false);
            sw.WriteLine(text.text);
            sw.Flush();
            sw.Close();
            i++;
            InputField form = GameObject.Find("InputField").GetComponent<InputField>();
            form.text = "";
        }
        else
        {
            StreamWriter sw = new StreamWriter("../InfoData.txt", append: true);
            sw.WriteLine(text.text);
            sw.Flush();
            sw.Close();
            InputField form = GameObject.Find("InputField").GetComponent<InputField>();
            form.text = "";
        }
    }

    public void OnClickNext()
    {
        SceneManager.LoadScene("ColumnScene");
    }
}