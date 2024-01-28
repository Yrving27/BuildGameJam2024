using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grade : MonoBehaviour
{
    public Animation anima;
    public AnimationClip v1, v2;

    public bool encostou;

    private void Start()
    {
        anima.Stop();
    }
    private void Update()
    {
        if (encostou)
        {
            if(anima.clip != v1)
            {
                anima.clip = v1;
                anima.Play();
            }
        }
        else
        {
            if(anima.clip != v2)
            {
                anima.clip = v2;
                anima.Play();
            }
        }
    }
}
