using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;

	public Canvas Canvas
	{
		get { return _canvas; }
		set { _canvas = value; }
	}

	/**
	 * Metodo per mostrare il canvas sulla lavagna bianca
	 */
	public void ShowCanvas()
	{
		Canvas.GetComponent<Canvas>().enabled = true;
	}
}
