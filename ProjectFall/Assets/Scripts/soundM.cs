using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundM : MonoBehaviour
{
    [SerializeField]
    public Slider volumeSlider;
    public Image i1, i2;
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            
        }
        else
        {
            
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        sIcon();
        Save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    void Update()
    {
        sIcon();
    }
    private void sIcon()
    {
        if (volumeSlider.value <= 0)
        {
            
            i2.enabled = true;
            i1.enabled = false;
        }
        else
        {
            i2.enabled = false;
            i1.enabled = true;
        }
    }
}
