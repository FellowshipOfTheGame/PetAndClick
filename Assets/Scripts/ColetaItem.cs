using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaItem : MonoBehaviour
{
	public GameMaster master;
	public int id;
	public int quest;
	public bool isQuestItem;
	public GameObject itemButton;
	public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
         master = GameObject.FindWithTag("Master").GetComponent(typeof(GameMaster)) as GameMaster;
         if(master.inventorySlots[id])
         	item.SetActive(false);
    }
    public void Coletar(){
        master.CollectItem(id);
        if(isQuestItem)
        master.CumpriuQuest();
    }

    void OnEnable()
    {
    	if(PlayerPrefs.GetInt("Current Quest")==quest)
    		itemButton.SetActive(true);
    }
}
