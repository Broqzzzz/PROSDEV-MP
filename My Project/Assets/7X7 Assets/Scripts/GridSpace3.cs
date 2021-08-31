using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace3 : MonoBehaviour
{
	public Button button;
	public Text buttonText;
	public Sprite newButtonImageX;
	public Sprite newButtonImageO;

	private GameController3 gameController3;
	
	public void SetSpace()
	{

		if (gameController3.GetPlayerSide() != null)
			buttonText.text = gameController3.GetPlayerSide();
		if(buttonText.text== "X")
		{
			button.image.sprite = newButtonImageX;
		}
		else
		{
			button.image.sprite = newButtonImageO;
		}

		button.interactable = false;
		gameController3.EndTurn();

	}

	public void SetGameControllerReference(GameController3 controller)
	{
		gameController3 = controller;

	}

}
