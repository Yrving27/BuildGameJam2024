using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_light : MonoBehaviour
{
    public Light l;
    public bool power;
    private SphereCollider lightCollider;
    private float minColliderRange = 3.2f;
    private float maxColliderRange = 10f;

    private void Start()
    {
        lightCollider = l.gameObject.GetComponentInChildren<SphereCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && power == false)
        {
            PowerLight();
            power = true;
            Game_controller.instance.DiminuiEnergia();
        }
    }


    public void PowerLight()
    {
        l.range = 25;
        l.intensity = 25;
        lightCollider.radius = maxColliderRange;
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
        if (l.range != 8)
        {
            l.range -= 0.5f;
            Invoke("TiraPower", 0.1f);
            if(l.intensity != 20)
            {
                l.intensity -= 0.5f;
            }
            if(lightCollider.radius > minColliderRange)
            {
                lightCollider.radius -= 0.2f;
            }
        }
        else
        {
            power = false;
        }
    }

}
