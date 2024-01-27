using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mixer_controller : MonoBehaviour
{

    public static Mixer_controller Mixer;
    public Slider SliderPrincipal;
    public AudioSource music;
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


}
