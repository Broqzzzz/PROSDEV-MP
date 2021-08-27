using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject HowToPlayPanel;
    public Button HowTo, back;

    void Start()
    {
        HowToPlayPanel.SetActive(false);
    }

    public void clicked (Button HowTo) {
        Debug.Log("clicked");
        HowToPlayPanel.SetActive(true);
    }

    public void clickBack (Button back) {
        HowToPlayPanel.SetActive(false);
    }

}
