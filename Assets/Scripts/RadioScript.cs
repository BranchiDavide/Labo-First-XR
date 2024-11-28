using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    private AudioSource audio;
    public void StartRadio()
    {
        if (audio.isPlaying)
        {
            audio.Pause();
            GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        else
        {
            audio.Play();
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
}
