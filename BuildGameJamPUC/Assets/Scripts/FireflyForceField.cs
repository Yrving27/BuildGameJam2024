using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflyForceField : MonoBehaviour
{
    private ParticleSystemForceField forceField;

    private void Start()
    {
        forceField = GetComponent<ParticleSystemForceField>();
        forceField.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            forceField.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            forceField.enabled = false;
        }
    }
}
