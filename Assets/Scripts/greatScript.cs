using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greatScript : MonoBehaviour
{
    [SerializeField]
    ParticleSystem gwiazdki;
    void OnEnable()
    {
        gwiazdki.Play();
        turnOff();
    }

    IEnumerator turnOff()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        yield return null;
    }
}
