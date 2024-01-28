using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    [SerializeField] GameObject panel;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void SetPanelActive(bool active)
    {
        panel.SetActive(active);
    }
}
