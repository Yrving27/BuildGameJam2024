using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{

    void Start()
    {
        Game_controller.instance.j = 7;
        Debug.Log(Game_controller.instance);
    }

    void Update()
    {
        
    }
}
