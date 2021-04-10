using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuInGameScript : MonoBehaviour
{
	public bool isInInventory=false;
	public bool isUp=false;
	public Animator canvas_anim;

	public void botaoMenuInventory(bool isInvetoryButton){
		if(!isUp){
			canvas_anim.Play("Up");
			isUp=true;
		}
		else{
			if(isInInventory==isInvetoryButton){
				canvas_anim.Play("Down");
				isUp=false;
			}
		}
		isInInventory=isInvetoryButton;
	}
	
	public void closeMenuInventory(){
		if(isUp){
			canvas_anim.Play("Down");
			isUp=false;
		}
	}


}
