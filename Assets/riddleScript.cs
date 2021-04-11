using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
using TMPro;
public class riddleScript : MonoBehaviour
{
	public string resposta;
	public GameObject panel_acertou;
	public GameObject panel_errou;
	public GameObject panel_input;
 	public TMP_InputField input;

	public void ConfirmouResposta(){
		if(input.text.ToLower()==resposta){
			panel_input.SetActive(false);
			panel_acertou.SetActive(true);
		}else{
			panel_input.SetActive(false);
			panel_errou.SetActive(true);
		}
	}

	public void SalaLiberada(){
		gameObject.SetActive(false);
	}

	public void VoltarPanel(){
			panel_input.SetActive(true);
			panel_errou.SetActive(false);
	}
}
