using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class txt_power : MonoBehaviour
{
    void Awake()
    {
        if(Game_controller.instance.txt_energia == null)
        {
            Game_controller.instance.txt_energia = this.gameObject.GetComponent<TextMeshPro>();
        }
    }

}
