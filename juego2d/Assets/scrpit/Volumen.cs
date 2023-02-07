using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volumen : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            audioSource.volume = Mathf.Max(0, audioSource.volume - 0.1f);
            audioSource2.volume = Mathf.Max(0, audioSource2.volume - 0.1f);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            audioSource.volume = Mathf.Min(1, audioSource.volume + 0.1f);
            audioSource2.volume = Mathf.Min(1, audioSource2.volume + 0.1f);
        }
    }
}
