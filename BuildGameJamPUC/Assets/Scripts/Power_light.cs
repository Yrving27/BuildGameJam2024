using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_light : MonoBehaviour
{
    public Light l;
    public bool power;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && power == false)
        {
            PowerLight();
            power = true;
        }
    }


    public void PowerLight()
    {
        l.range = 25;
        l.intensity = 25;
        //if (l.range != 20)
        //{
            
            //l.range += 0.5f;
            //Invoke("PowerLight", 0.1f);
        //}
        //else
        //{
            
            Invoke("TiraPower", 2f);
        //}
    }

    public void TiraPower()
    {
        if (l.range != 10)
        {
            l.range -= 0.5f;
            Invoke("TiraPower", 0.1f);
            if(l.intensity != 20)
            {
                l.intensity -= 0.5f;
            }
        }
        else
        {
            power = false;
        }
    }

}
