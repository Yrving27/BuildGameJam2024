using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject portal;

    public void SetPortalState(bool active)
    {
        portal.SetActive(active);
        GetComponent<BoxCollider>().enabled = active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Próxima fase");
        }
    }
}
