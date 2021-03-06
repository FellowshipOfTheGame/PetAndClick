using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
	[SerializeField]
	GameObject[] menu_canvas;
	int atual=0;
	public void LoadScene(string scene)
	{
		SceneManager.LoadScene(scene);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
	public void ChangeCanvas(int id){
		for(var i=0; i<menu_canvas.Length;i++){
				menu_canvas[i].SetActive(false);
		}
		menu_canvas[id].SetActive(true);
		atual=id;
	}
}
