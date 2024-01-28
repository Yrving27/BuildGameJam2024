using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portao : MonoBehaviour,IObserver
{
    public Animation anima;
    public AnimationClip v1, v2;

    public void Start()
    {
        EventEmitter.instance.AddObserver(this);
        anima.Stop();
    }

    public void AbrePortao()
    {
        
    }

    public void FechaPortao()
    {
        
    }

    public void PressNotify()
    {
        anima.clip = v1;
        anima.Play();
    }

    public void ReleaseNotify()
    {
        anima.clip = v2;
        anima.Play();
    }
}
