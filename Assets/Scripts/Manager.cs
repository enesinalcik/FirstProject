using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject charCylinder;
    private Rigidbody effectible;
    private float cylinderCordinate;

    // Start is called before the first frame update
    void Start()
    {
        cylinderCordinate = charCylinder.transform.position.x;
        Debug.Log(cylinderCordinate);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(charCylinder.active);
        var position = charCylinder.transform.position.x;
        effectible = charCylinder.GetComponent<Rigidbody>();
        effectible.AddForce(Vector3.right * Time.deltaTime * 10000, ForceMode.Acceleration);
        Debug.Log(position - cylinderCordinate);
        cylinderCordinate = position;
    }
}