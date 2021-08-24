using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
	public Text[] buttonList;
	private string playerSide;


	public GameObject gameOverPanel;
	public Text gameOverText;
	public GameObject header;
	public Text headerText;

	void Awake()
	{
		gameOverPanel.SetActive(false);
		SetGameControllerReferenceOnButtons();
		playerSide ="X";

	}

	void SetGameControllerReferenceOnButtons()
	{
		
		for (int i=0; i < buttonList.Length; i ++)
		{	
			buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);

		}
	}

	public string GetPlayerSide()
	{
		return playerSide;
	}
	public void EndTurn()
	{	
		
		if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
		{
			GameOver();
		}
		if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
		{
			GameOver();
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
		gameOverPanel.SetActive(true);
		gameOverText.text = playerSide + " Wins! ";
	
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
