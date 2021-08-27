using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
	public Button button;
	public Text buttonText;
	public Sprite newButtonImageX;
	public Sprite newButtonImageO;

	private GameController gameController;
	
	public void SetSpace()
	{
		
		buttonText.text = gameController.GetPlayerSide();
		if(buttonText.text== "X")
		{
			button.image.sprite = newButtonImageX;
		}
		else
		{
			button.image.sprite = newButtonImageO;
		}

		button.interactable = false;
		gameController.EndTurn();

	}

	public void SetGameControllerReference(GameController controller)
	{
		gameController = controller;

	}

}
