using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stum_power : MonoBehaviour
{
    public float raycastDistance = 5f;
    public GameObject lanterna;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 raycastOrigin = lanterna.transform.position;
            Vector3 raycastDirection = lanterna.transform.forward;
            Debug.DrawRay(raycastOrigin, raycastDirection * raycastDistance, Color.red);

            RaycastHit hit;
            if (Physics.Raycast(raycastOrigin, raycastDirection, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("enemy"))
                {
                    Debug.Log("Objeto identificado à frente!");
                }
            }
        }
    }
}
