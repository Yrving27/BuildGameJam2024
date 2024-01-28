using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stum_power : MonoBehaviour
{
    public float lightDuration = 2f;
    private new Light light;
    private new BoxCollider collider;

    private void Start()
    {
        light = GetComponent<Light>();
        collider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            light.enabled = true;
            collider.enabled = true;
            Invoke("DisableLight", lightDuration);
        }
    }

    private void DisableLight()
    {
        light.enabled = false;
        collider.enabled = false;
    }
}
