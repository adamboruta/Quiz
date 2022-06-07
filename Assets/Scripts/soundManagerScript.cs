using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource positiveSound;

    public void PlayPositiveSound()
    {
        positiveSound.Play();
    }
}
