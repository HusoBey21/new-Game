using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioSource asd;
    public AudioClip sfx;
     void Start()
    {
        asd = this.GetComponent<AudioSource>();
    }
     void Update()
    {

        asd.clip = sfx;
        if(!asd.isPlaying)
        {
            asd.Play();
        }
       
    }
}
