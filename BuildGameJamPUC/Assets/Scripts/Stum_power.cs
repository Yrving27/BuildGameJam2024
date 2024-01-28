using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stum_power : MonoBehaviour
{
    private AudioSource source;
    public float lightDuration = 2f;
    private Light light;
    private BoxCollider collider;

    private void Start()
    {
        light = GetComponent<Light>();
        collider = GetComponent<BoxCollider>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            light.enabled = true;
            collider.enabled = true;
            source.Play();
            Invoke("DisableLight", lightDuration);
        }
    }

    private void DisableLight()
    {
        light.enabled = false;
        collider.enabled = false;
    }
}
