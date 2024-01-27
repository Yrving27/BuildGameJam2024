using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_esc : MonoBehaviour
{
    public bool Escape;
    public GameObject panel_esc;

    public GameObject panel_principal, panel_configSom;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Escape = !Escape;
            if (Escape)
            {
                panel_esc.SetActive(Escape);

                panel_principal.SetActive(true);
                panel_configSom.SetActive(false);
            }
            else
            {
                panel_esc.SetActive(Escape);
            }
        }
    }

    public void DesligarEscape()
    {
        Escape = false;
        panel_esc.SetActive(Escape);
    }

}
