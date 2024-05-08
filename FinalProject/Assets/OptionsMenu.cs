using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.Rendering;

public class OptionsMenu : MonoBehaviour
{
    [Header ("Audio")]
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolume;
    [SerializeField] Slider musicVolume;
    [SerializeField] Slider sfxVolume;

    [Header("Resolution")]
    [SerializeField] TMP_Dropdown resDropdown;
    Resolution[] resolutions;
    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        masterVolume.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVolume.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVolume.value = PlayerPrefs.GetFloat("SFXVolume");
        GetResolutionOptions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetmasterVolume(){
        audioMixer.SetFloat("MasterVolume",changeAud(masterVolume.value));
        PlayerPrefs.SetFloat("MasterVolume",masterVolume.value);
    }

    public void SetMusicVolume(){
        audioMixer.SetFloat("MusicVolume",changeAud(musicVolume.value));
        PlayerPrefs.SetFloat("MusicVolume",musicVolume.value);
    }

    public void SetSFXVolume(){
        audioMixer.SetFloat("SFXVolume",changeAud(sfxVolume.value));
        PlayerPrefs.SetFloat("SFXVolume",sfxVolume.value);
    }

    float changeAud(float sliderVal){
        return Mathf.Log10(Mathf.Max(sliderVal, 0.00001f)) *20;
    }

    void GetResolutionOptions(){
        resDropdown.ClearOptions();
        resolutions = Screen.resolutions;
        for(int i=0; i<resolutions.Length; i++){
            TMP_Dropdown.OptionData newOption;
            newOption = new TMP_Dropdown.OptionData(resolutions[i].width.ToString() + "x" + resolutions[i].height.ToString());
            resDropdown.options.Add(newOption);
        }
    }

    public void ChooseResolution(){
        Screen.SetResolution(resolutions[resDropdown.value].width,resolutions[resDropdown.value].height,true);
    }

    public void OpenOptions(){
        canvas.enabled = true;
    }

    public void CloseOptions(){
        canvas.enabled = false;
    }
}
