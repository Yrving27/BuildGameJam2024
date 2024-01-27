using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEmitter : MonoBehaviour
{
    public static EventEmitter instance;
    public List<IObserver> list = new();
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void AddObserver(IObserver obs)
    {
        list.Add(obs);
    }

    public void PlatePressed()
    {
        foreach (IObserver obs in list)
        {
            obs.PressNotify();
        }
    }

    public void PlateReleased()
    {
        foreach (IObserver obs in list)
        {
            obs.ReleaseNotify();
        }
    }
}
