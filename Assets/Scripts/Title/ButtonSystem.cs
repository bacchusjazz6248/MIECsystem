using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject SB = GameObject.Find("StartButton");
        GameObject CB = GameObject.Find("ContinueButton");
        GameObject EB = GameObject.Find("ExitButton");
    }

    // Update is called once per frame
    public void OnClickSB()
    {
        SceneManager.LoadScene("InfoPlusScene");
    } 
    
    public void OnClickCB()
    {
        SceneManager.LoadScene("ConfirmScene");
    } 
    
    public void OnClickEB()
    {
        UnityEngine.Application.Quit();
    } 
}
