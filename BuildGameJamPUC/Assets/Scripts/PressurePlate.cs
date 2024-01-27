using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] bool pressOnce;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Box"))
        {
            EventEmitter.instance.PlatePressed();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!pressOnce)
        {
            if (other.CompareTag("Player") || other.CompareTag("Box"))
            {
                EventEmitter.instance.PlateReleased();
            }
        }
    }
}
