using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspecionarScript : MonoBehaviour
{
	public GameObject inspectPanel;
	public Sprite img;
	public Image image_obj;

	public void InspecionaItem(){
		inspectPanel.SetActive(true);
		image_obj.sprite=img;
	}
}
