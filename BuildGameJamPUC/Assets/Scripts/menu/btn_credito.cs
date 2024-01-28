using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_credito : MonoBehaviour
{
    public Image ima;
    public Sprite im1, im2;
    public GameObject g1, g2;

    public void setaD()
    {
        ima.sprite = im2;
        g2.SetActive(false);
        g1.SetActive(true);
        ima.SetNativeSize();
        Mixer_controller.Mixer.Click_Button();
    }
    public void setaE()
    {
        ima.sprite = im1;
        g2.SetActive(true);
        g1.SetActive(false);
        ima.SetNativeSize();
        Mixer_controller.Mixer.Click_Button();
    }

}
