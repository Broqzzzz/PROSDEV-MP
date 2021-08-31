using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour
{
    public Text[] buttonList;
    public string playerSide;

    public GameObject GameOverPanel;
    public Text gameOverText;

    public GameObject Header;
    public Text headerText;

    private int moveCount = 0;
   // public GameObject restartButton;

    void Awake()
    {
        GameOverPanel.SetActive(false);
        SetGameControllerReferenceOnButtons();
        playerSide = "X";
        moveCount = 0;
       // restartButton.SetActive(false);
    }
    void SetGameControllerReferenceOnButtons()
    {
        for(int i=0; i< buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace2>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return playerSide;
    }

    public void EndTurn()
    {
        moveCount++;
        // Horizontal 

        if(buttonList[0].text == playerSide &&
            buttonList[1].text == playerSide &&
              buttonList[2].text == playerSide &&
                buttonList[3].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[1].text == playerSide &&
         buttonList[2].text == playerSide &&
           buttonList[3].text == playerSide &&
             buttonList[4].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[1].text == playerSide &&
        buttonList[2].text == playerSide &&
          buttonList[3].text == playerSide &&
            buttonList[4].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[5].text == playerSide &&
    buttonList[6].text == playerSide &&
      buttonList[7].text == playerSide &&
        buttonList[8].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[6].text == playerSide &&
  buttonList[7].text == playerSide &&
    buttonList[8].text == playerSide &&
      buttonList[9].text == playerSide)
        {
            GameOver();
        }


        if (buttonList[10].text == playerSide &&
  buttonList[11].text == playerSide &&
    buttonList[12].text == playerSide &&
      buttonList[13].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[11].text == playerSide &&
            buttonList[12].text == playerSide &&
            buttonList[13].text == playerSide &&
            buttonList[14].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[15].text == playerSide &&
          buttonList[16].text == playerSide &&
          buttonList[17].text == playerSide &&
          buttonList[18].text == playerSide)
        {
            GameOver();
        }


        if (buttonList[16].text == playerSide &&
          buttonList[17].text == playerSide &&
          buttonList[18].text == playerSide &&
          buttonList[19].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[20].text == playerSide &&
         buttonList[21].text == playerSide &&
         buttonList[22].text == playerSide &&
         buttonList[23].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[21].text == playerSide &&
        buttonList[22].text == playerSide &&
        buttonList[23].text == playerSide &&
        buttonList[24].text == playerSide)
        {
            GameOver();
        }

        // Vertical
        if (buttonList[0].text == playerSide &&
        buttonList[5].text == playerSide &&
        buttonList[10].text == playerSide &&
        buttonList[15].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[5].text == playerSide &&
         buttonList[10].text == playerSide &&
         buttonList[15].text == playerSide &&
         buttonList[20].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[1].text == playerSide &&
            buttonList[6].text == playerSide &&
             buttonList[11].text == playerSide &&
             buttonList[16].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[6].text == playerSide &&
         buttonList[11].text == playerSide &&
         buttonList[16].text == playerSide &&
         buttonList[21].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[2].text == playerSide &&
           buttonList[7].text == playerSide &&
            buttonList[12].text == playerSide &&
            buttonList[17].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[7].text == playerSide &&
         buttonList[12].text == playerSide &&
         buttonList[17].text == playerSide &&
         buttonList[22].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[3].text == playerSide &&
          buttonList[8].text == playerSide &&
           buttonList[13].text == playerSide &&
           buttonList[18].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[8].text == playerSide &&
         buttonList[13].text == playerSide &&
         buttonList[18].text == playerSide &&
         buttonList[23].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[4].text == playerSide &&
          buttonList[9].text == playerSide &&
           buttonList[14].text == playerSide &&
           buttonList[19].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[9].text == playerSide &&
         buttonList[14].text == playerSide &&
         buttonList[19].text == playerSide &&
         buttonList[24].text == playerSide)
        {
            GameOver();
        }



        // Diagonal
        if (buttonList[0].text == playerSide &&
       buttonList[6].text == playerSide &&
       buttonList[12].text == playerSide &&
       buttonList[18].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[1].text == playerSide &&
             buttonList[7].text == playerSide &&
             buttonList[13].text == playerSide &&
             buttonList[19].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[3].text == playerSide &&
            buttonList[7].text == playerSide &&
            buttonList[11].text == playerSide &&
            buttonList[15].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[4].text == playerSide &&
         buttonList[8].text == playerSide &&
         buttonList[12].text == playerSide &&
         buttonList[16].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[5].text == playerSide &&
            buttonList[11].text == playerSide &&
             buttonList[17].text == playerSide &&
             buttonList[23].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[9].text == playerSide &&
        buttonList[13].text == playerSide &&
         buttonList[17].text == playerSide &&
         buttonList[21].text == playerSide)
        {
            GameOver();
        }

        if (buttonList[6].text == playerSide &&
            buttonList[12].text == playerSide &&
             buttonList[18].text == playerSide &&
             buttonList[24].text == playerSide)
        {
            GameOver();
        }


        if (buttonList[8].text == playerSide &&
            buttonList[12].text == playerSide &&
             buttonList[16].text == playerSide &&
             buttonList[20].text == playerSide)
        {
            GameOver();
        }


        if (buttonList[9].text == playerSide &&
            buttonList[13].text == playerSide &&
             buttonList[17].text == playerSide &&
             buttonList[21].text == playerSide)
        {
            GameOver();
        }

        if(moveCount >= 25)
        {
           
           SetGameOverText(" DRAW!! ");
        }
        ChangeSides();
        ChangeHeader();

        //Debug.Log("End Turn is here!");
    }

    void GameOver()
    {
        SetBoardInteractable(false);
        SetGameOverText( playerSide + " WINS!");
     //   restartButton.SetActive(true);
    }

    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";
    }

    void SetGameOverText(string value)
    {
        GameOverPanel.SetActive(true);
        gameOverText.text = value;
    }


        void SetBoardInteractable(bool toggle)
        {
            for (int i = 0; i < buttonList.Length; i++)
            {
                buttonList[i].GetComponentInParent<Button>().interactable = toggle;
                buttonList[i].text = "";

            }
        }

    void ChangeHeader()
    {
        Header.SetActive(true);
        headerText.text = "Player " + playerSide + "'s turn";
    }

}

