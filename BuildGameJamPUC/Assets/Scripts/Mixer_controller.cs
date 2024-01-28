using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mixer_controller : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider generalVol;
    public Slider fxVol;
    public Slider musicVol;

    private void OnEnable()
    {
        float masterValue;
        if (mixer.GetFloat("Master", out masterValue))
        {
            generalVol.value = masterValue;
        }

        float musicValue;
        if (mixer.GetFloat("Music", out musicValue))
        {
            musicVol.value = musicValue;
        }

        float fxValue;
        if (mixer.GetFloat("Effects", out fxValue))
        {
            fxVol.value = fxValue;
        }
    }

    public void GeneralVolChange()
    {
        mixer.SetFloat("Master", generalVol.value);
    }

    public void MusicVolChange()
    {
        mixer.SetFloat("Music", musicVol.value);
    }

    public void FXVolChange()
    {
        mixer.SetFloat("Effects", fxVol.value);
    }
}
