using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_config : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelPrincipal;

    public void PainelConfig()
    {
        panel.SetActive(true);
        panelPrincipal.SetActive(false);
    }
    public void FechaPainelConfig()
    {
        panel.SetActive(false);
        panelPrincipal.SetActive(true);
    }
}
