using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{


    private Rigidbody effectible;
    //public GameObject Cube;
  
    int up,down,left,right,jump;

    // Start is called before the first frame update
    void Start()
    {
        effectible = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (up>0)
        {
            effectible.AddTorque(Vector3.forward);
            up--;
        }
        if (down > 0)
        {
            effectible.AddTorque(Vector3.back);
            down--;
        }
        if (right > 0)
        {
            effectible.AddTorque(Vector3.right);
            right--;
        }
        if (left > 0)
        {
            effectible.AddTorque(Vector3.left);
            left--;
        }

        if (jump > 0)
        {
            effectible.AddForce(Vector3.up);
            jump--;

        }
    }
     
    
    public void UpButton()
    {
        up = 2;

        effectible.AddTorque(Vector3.forward);




    }

    public void DownButton()
    {
        down = 2;

        effectible.AddTorque(Vector3.back);


    }


    public void RightButton()
    {

        right = 2;

        effectible.AddTorque(Vector3.right);
    }


    public void LeftButton()
    {
        left = 2;

        effectible.AddTorque(Vector3.left);


    }

    public void JumpButton()
    {
        jump = 2;
        effectible.AddForce(Vector3.up);
        
    }
}   


