using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qInfoUIScript : MonoBehaviour
{
     Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void showAnimation()
    {
        anim.SetTrigger("show");
    }
}
