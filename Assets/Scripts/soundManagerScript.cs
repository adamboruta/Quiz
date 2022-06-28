using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource positiveSound;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    public void PlayPositiveSound()
    {
        positiveSound.Play();
    }
}
