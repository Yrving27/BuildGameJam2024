using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : MonoBehaviour
{
    private AudioSource source;
    public bool playing;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        playing = source.isPlaying;
    }

    public void PlayAudio(AudioClip clip)
    {
        if (source.clip != clip)
        {
            source.clip = clip;
        }
        source.Play();
    }
}
