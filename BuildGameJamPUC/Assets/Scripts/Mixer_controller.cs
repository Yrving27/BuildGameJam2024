using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mixer_controller : MonoBehaviour
{

    public static Mixer_controller Mixer;
    public Slider SliderPrincipal;
    public AudioSource music;
    public AudioSource powerLight;
    public AudioSource click;
    private void Awake()
    {
        if (Mixer == null)
        {
            Mixer = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if(SliderPrincipal != null)
        {
            music.volume = SliderPrincipal.value;
        }
    }

    public void PowerLight()
    {
        powerLight.Play();
    }

    public void Click_Button()
    {
        click.Play();
    }


}
