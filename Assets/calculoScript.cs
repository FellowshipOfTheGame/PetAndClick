using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
using TMPro;
public class calculoScript : MonoBehaviour
{
	public string resposta;
	public GameObject panel_acertou;
	public GameObject panel_errou;
	public GameObject panel_input;
 	public TMP_InputField input;
 	public GameObject seta_entra;

 	public void Start(){
        if(PlayerPrefs.GetInt("CalculoCompletado")==1)
        	SalaLiberada();
 	}
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
		seta_entra.SetActive(true);
		gameObject.SetActive(false);
        PlayerPrefs.SetInt("CalculoCompletado", 1);
	}

	public void VoltarPanel(){
			panel_input.SetActive(true);
			panel_errou.SetActive(false);
	}
}
