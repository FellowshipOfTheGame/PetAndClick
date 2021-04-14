using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaSetas : MonoBehaviour
{
	public GameMaster master;
	public GameObject[] setas;
	public int quest_ativa;

    // Start is called before the first frame update
    void Start()
    {
         master = GameObject.FindWithTag("Master").GetComponent(typeof(GameMaster)) as GameMaster;
         if(PlayerPrefs.GetInt("Current Quest")>=quest_ativa){
    		foreach(GameObject seta in setas){
    			seta.SetActive(true);
    		}
    	}
    }



    
}
