using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_controller : MonoBehaviour
{
    public static Game_controller instance;

    public int energia_power = 100;
    public int energia_total = 100;

    public TMP_Text txt_energia;

    public bool Lamparina = false;
    public bool isPaused;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetPause(bool pause)
    {
        isPaused = pause;
    }
    
    public void DiminuiEnergia()
    {
        int v = Random.Range(8, 12);
        energia_total -= v;
        menos();
    }

    public void SoltaEnergy()
    {
        int v = Random.Range(10, 17);
        energia_total -= v;
        menos();
    }

    public void menos()
    {
        if(energia_power > energia_total)
        {
            energia_power -= 1;
            txt_energia.text = energia_power.ToString()+"%";
            Invoke("menos", 0.2f);
        }
    }
}
