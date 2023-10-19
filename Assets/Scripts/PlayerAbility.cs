using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    [SerializeField] private PlayerAudio playerAudio;
    [SerializeField] private KeyCode meowKeyCode;
    public void Meow()
    {
        playerAudio.PLayMeowRandom();
    }

    private void Update()
    {
        if (Input.GetKeyDown(meowKeyCode))
        {
            Meow();
        }
    }
}
