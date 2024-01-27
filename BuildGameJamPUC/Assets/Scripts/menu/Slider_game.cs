using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_game : MonoBehaviour
{
    
    private void Start()
    {
        Mixer_controller.Mixer.SliderPrincipal = this.gameObject.GetComponent<Slider>();
        this.gameObject.GetComponent<Slider>().value = Mixer_controller.Mixer.music.volume;
    }
}
