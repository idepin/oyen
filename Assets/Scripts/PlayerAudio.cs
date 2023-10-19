using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceFootstep;
    [SerializeField] private AudioSource audioSourceMeow;
    [SerializeField] private AudioClip footstepClip;
    [SerializeField] private AudioClip[] meowClips;

    public void PlayFootStep()
    {
        if (!audioSourceFootstep.isPlaying)
        {
            audioSourceFootstep.PlayOneShot(footstepClip);
        }
        
    }

    public void PLayMeowRandom()
    {
        if(!audioSourceMeow.isPlaying)
        {
            audioSourceMeow.PlayOneShot(meowClips[Random.Range(0, meowClips.Length)]);
            Debug.Log("Played meow");
        }
        
    }

}
