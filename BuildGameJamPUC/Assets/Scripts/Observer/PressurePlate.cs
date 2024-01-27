using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] bool pressOnce;
    private int collisions = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Box") && collisions == 0)
        {
            EventEmitter.instance.PlatePressed();
            collisions++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!pressOnce)
        {
            if (other.CompareTag("Player") || other.CompareTag("Box") && collisions > 0)
            {
                EventEmitter.instance.PlateReleased();
                collisions--;
            }
        }
    }
}
