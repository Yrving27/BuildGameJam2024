using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_cube : MonoBehaviour
{
    public grade g;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            g.encostou = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            g.encostou = false;
        }
    }
}
