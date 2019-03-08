using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioo : MonoBehaviour
{
    public AudioSource kaynak;
    public AudioClip ses;


    public void jumpSound()
    {
        kaynak.PlayOneShot(ses);
            



    }
    





}
