using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeSound : MonoBehaviour
{


    public AudioSource kaynak2;
    public AudioClip ses2;


    public void closesound()
    {
        kaynak2.PlayOneShot(ses2);


    }

}
