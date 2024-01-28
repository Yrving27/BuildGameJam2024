using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_portao : MonoBehaviour
{
    public GameObject gb;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gb.GetComponent<portao>().AbrePortao();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (GetComponent<Collider>().gameObject.CompareTag("Player"))
        {
            gb.GetComponent<portao>().FechaPortao();
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        
    }
}
