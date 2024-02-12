using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] sounds;
    void Start()
    {
        source = GetComponent<AudioSource>();
        int randSound = Random.Range(0, sounds.Length);
        source.clip = sounds[randSound];
        source.Play();
    }

    void Update()
    {
        
    }
}
