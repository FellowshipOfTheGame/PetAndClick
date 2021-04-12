using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
	public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindWithTag("Audio").GetComponent(typeof(AudioManager)) as AudioManager;
    }
    public void PlaySeta(){
    	audioManager.Play("seta");
    }
}
