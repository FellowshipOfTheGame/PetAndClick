using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

	public bool[] inventorySlots;
	public GameObject[] slotsObj;
    private static GameMaster instance;
    void Awake()
        {
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(instance);
            }else
            {
                Destroy(gameObject);
            }
        }

    public void CollectItem(int item_id){
    	if(item_id<inventorySlots.Length && item_id>=0){
    		inventorySlots[item_id]=true;
    		slotsObj[item_id].SetActive(true);
    	}
    }

    public void RemoveItem(int item_id){
    	if(item_id<inventorySlots.Length && item_id>=0){
    		inventorySlots[item_id]=false;
    		slotsObj[item_id].SetActive(false);
    	}
    }

}
