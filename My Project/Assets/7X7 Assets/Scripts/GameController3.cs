using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController3 : MonoBehaviour
{
	public Text[] buttonList;
	private string playerSide;


	public GameObject gameOverPanel;
	public Text gameOverText;
	public GameObject header;
	public Text headerText;

	private int moveCount;
	private bool isOver;

	void Awake()
	{
		gameOverPanel.SetActive(false);
		SetGameControllerReferenceOnButtons();
		playerSide ="X";
		moveCount = 0;
		isOver = false;

	}

	void SetGameControllerReferenceOnButtons()
	{
		
		for (int i=0; i < buttonList.Length; i ++)
		{	
			buttonList[i].GetComponentInParent<GridSpace3>().SetGameControllerReference(this);

		}
	}

	public string GetPlayerSide()
	{
		return playerSide;
	}
	public void EndTurn()
	{	
		moveCount++;
		isOver = false;
		//horizontal
		for(int i = 0; i < 4; i++)//line1
			if (buttonList[i].text == playerSide && buttonList[i+1].text == playerSide && buttonList[i+2].text == playerSide && buttonList[i+3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line2
			if (buttonList[i + 7].text == playerSide && buttonList[i + 7 + 1].text == playerSide && buttonList[i + 7 + 2].text == playerSide && buttonList[i + 7 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line3
			if (buttonList[i + 14].text == playerSide && buttonList[i + 14 + 1].text == playerSide && buttonList[i + 14 + 2].text == playerSide && buttonList[i + 14 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line4
			if (buttonList[i + 21].text == playerSide && buttonList[i + 21 + 1].text == playerSide && buttonList[i + 21 + 2].text == playerSide && buttonList[i + 21 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line5
			if (buttonList[i + 28].text == playerSide && buttonList[i + 28 + 1].text == playerSide && buttonList[i + 28 + 2].text == playerSide && buttonList[i + 28 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line6
			if (buttonList[i + 35].text == playerSide && buttonList[i + 35 + 1].text == playerSide && buttonList[i + 35 + 2].text == playerSide && buttonList[i + 35 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//line7
			if (buttonList[i + 42].text == playerSide && buttonList[i + 42 + 1].text == playerSide && buttonList[i + 42 + 2].text == playerSide && buttonList[i + 42 + 3].text == playerSide)
			{
				GameOver();
				isOver = true;
			}

		//vertical
		for (int i = 0; i < 4; i++)//vline1
			if (buttonList[i*7].text == playerSide && buttonList[i*7+7].text == playerSide && buttonList[i*7 + 14].text == playerSide && buttonList[i*7 + 21].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline2
			if (buttonList[i * 7 + 1].text == playerSide && buttonList[i * 7 + 8].text == playerSide && buttonList[i * 7 + 15].text == playerSide && buttonList[i * 7 + 22].text == playerSide)
			{//1 8 15 22/8 15 22 29/15 22 29 36/ 22 29 36 43
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline3
			if (buttonList[i * 7 + 2].text == playerSide && buttonList[i * 7 + 9].text == playerSide && buttonList[i * 7 + 16].text == playerSide && buttonList[i * 7 + 23].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline4
			if (buttonList[i * 7 + 3].text == playerSide && buttonList[i * 7 + 10].text == playerSide && buttonList[i * 7 + 17].text == playerSide && buttonList[i * 7 + 24].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline5
			if (buttonList[i * 7 + 4].text == playerSide && buttonList[i * 7 + 11].text == playerSide && buttonList[i * 7 + 18].text == playerSide && buttonList[i * 7 + 25].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline6
			if (buttonList[i * 7 + 5].text == playerSide && buttonList[i * 7 + 12].text == playerSide && buttonList[i * 7 + 19].text == playerSide && buttonList[i * 7 + 26].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//vline7
			if (buttonList[i * 7 + 6].text == playerSide && buttonList[i * 7 + 13].text == playerSide && buttonList[i * 7 + 20].text == playerSide && buttonList[i * 7 + 27].text == playerSide)
			{
				GameOver();
				isOver = true;
			}

		//diagonal/
		for (int i = 0; i < 4; i++)//d/line1
			if (buttonList[i].text == playerSide && buttonList[i + 8].text == playerSide && buttonList[i + 16].text == playerSide && buttonList[i + 24].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line2
			if (buttonList[i + 7].text == playerSide && buttonList[i + 7 + 8].text == playerSide && buttonList[i + 7 + 16].text == playerSide && buttonList[i + 7 + 24].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line3
			if (buttonList[i + 14].text == playerSide && buttonList[i + 14 + 8].text == playerSide && buttonList[i + 14 + 16].text == playerSide && buttonList[i + 14 + 24].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line4
			if (buttonList[i + 21].text == playerSide && buttonList[i + 21 + 8].text == playerSide && buttonList[i + 21 + 16].text == playerSide && buttonList[i + 21 + 24].text == playerSide)
			{
				GameOver();
				isOver = true;
			}


		//diagonal\
		for (int i = 0; i < 4; i++)//d/line1
			if (buttonList[i + 3].text == playerSide && buttonList[i + 3 + 6].text == playerSide && buttonList[i + 3 + 12].text == playerSide && buttonList[i + 3 + 18].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line2
			if (buttonList[i + 7 + 3].text == playerSide && buttonList[i + 7 + 3 + 6].text == playerSide && buttonList[i + 7 + 3 + 12].text == playerSide && buttonList[i + 7 + 3 + 18].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line3
			if (buttonList[i + 14 + 3].text == playerSide && buttonList[i + 14 + 3 + 6].text == playerSide && buttonList[i + 14 + 3 + 12].text == playerSide && buttonList[i + 14 + 3 + 18].text == playerSide)
			{
				GameOver();
				isOver = true;
			}
		for (int i = 0; i < 4; i++)//d/line4
			if (buttonList[i + 21 + 3].text == playerSide && buttonList[i + 21 + 3 + 6].text == playerSide && buttonList[i + 21 + 3 + 12].text == playerSide && buttonList[i + 21 + 3 + 18].text == playerSide)
			{
				GameOver();
				isOver = true;
			}





		if (moveCount >= 49 && !isOver) //7x7=49
		{
			setText("It's a Draw!");
		}

		ChangeSides();
		ChangeHeader();
	}

	void GameOver()
	{
		for (int i = 0; i < buttonList.Length; i++)
		{
			buttonList[i].GetComponentInParent<Button>().interactable = false;
		}
		// gameOverPanel.SetActive(true);
		// gameOverText.text = "Player " + playerSide + " Wins! ";
		setText("Player " + playerSide + " Wins!");
	}
	void setText (string value)
	{
		gameOverPanel.SetActive(true);
		gameOverText.text = value;
	}
	void ChangeSides()
	{
		
		playerSide = (playerSide == "X") ? "O" : "X";
		
	}
	void ChangeHeader()
	{
		header.SetActive(true);
		headerText.text = "Player " + playerSide + "'s turn";
	}	

}
