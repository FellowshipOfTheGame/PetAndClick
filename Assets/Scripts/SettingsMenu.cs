using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
	public AudioMixer audioMixer;
	Resolution[] resolutions;

	public void SetVolume(float volume)
	{
		audioMixer.SetFloat("MasterVolume", (volume*80-80));
	}

	public void SetMusica(float volume)
	{
		audioMixer.SetFloat("MusicVolume", (volume*80-80));
	}
	public void SetSFX(float volume)
	{
		audioMixer.SetFloat("SoundFXVolume", (volume*80-80));
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}

}
