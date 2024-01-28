using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamparina : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Power_light>().l.intensity = 20;
            collision.gameObject.GetComponent<Power_light>().l.range = 9.5f;
            Game_controller.instance.Lamparina = true;
            Destroy(this.gameObject);
        }
    }
}
