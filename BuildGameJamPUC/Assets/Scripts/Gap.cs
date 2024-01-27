using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gap : MonoBehaviour
{
    private bool filled;
    [SerializeField] float fallSpeed = 0.5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box") && !filled)
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            Transform collidedObj = other.transform;
            while(Vector3.Distance(transform.position, collidedObj.position) > 0.1f)
            {
                collidedObj.position = Vector3.MoveTowards(collidedObj.position, transform.position, fallSpeed * Time.deltaTime);
                filled = true;
            }
        }else if(other.CompareTag("Player") && !filled)
        {
            Debug.Log("Caiu no buraco");
        }
    }
}
