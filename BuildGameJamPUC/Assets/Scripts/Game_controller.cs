using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_controller : MonoBehaviour
{
    public static Game_controller instance;
    public int j = 0;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
