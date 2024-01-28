using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonologueTrigger : MonoBehaviour
{
    [SerializeField] Monologue monologue;
    public UnityEvent onDismissEvent = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MonologueDisplayer.instance.DisplayMonologue(monologue, this);
            Destroy(gameObject);
        }
    }
}
