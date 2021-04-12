using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class ativaFlow : MonoBehaviour
{
	public string flowTag;
    public void AtivaFlow(){
    	Fungus.Flowchart.BroadcastFungusMessage(flowTag);
    }
}
