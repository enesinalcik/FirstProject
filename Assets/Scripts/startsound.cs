using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startsound : MonoBehaviour
{
    public AudioSource kaynak;
    public AudioClip ses1;
    

    public void startSound()
    {
        kaynak.PlayOneShot(ses1);

               
    }
   
}
