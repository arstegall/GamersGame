using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2lvlSound : MonoBehaviour
{
    AudioSource efekt;

    public AudioClip sakupljeno;

    private void Start()
    {
        efekt = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            efekt.PlayOneShot(sakupljeno);
        }
    }
}
