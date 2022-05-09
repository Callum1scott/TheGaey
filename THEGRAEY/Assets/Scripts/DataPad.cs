using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPad : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip logAudioClip;

    private bool isPlay;
    private bool hasPlayed;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = logAudioClip;

        isPlay = false;
        hasPlayed = false;
    }

    private void Update()
    {
        if (audioSource.isPlaying == false)
        {
            isPlay = false;
        }
        else
        {
            isPlay = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            if(isPlay == false && hasPlayed == false)
            {
                audioSource.Play();
                hasPlayed = true;
            }
            else
            {
                Debug.Log("playing dumbass");
            }
        }
    }
}
