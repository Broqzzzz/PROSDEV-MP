using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace2 : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    // public string playerSide;
    public Sprite newButtonImageX;
    public Sprite newButtonImageO;


    private GameController2 gameController2;

    public void SetSpace()
    {
        buttonText.text = gameController2.GetPlayerSide();
        if (buttonText.text == "X")
        {
            button.image.sprite = newButtonImageX;
        }
        else
        {
            button.image.sprite = newButtonImageO;
        }
        button.interactable = false;
        gameController2.EndTurn();
    }

    public void SetGameControllerReference(GameController2 controller)
    {
        gameController2 = controller;
    }
}
