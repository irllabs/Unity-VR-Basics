using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private int myNumber;
    public GameObject myGameobject;

    // Start is called before the first frame update
    void Start()
    {
        // Message with a GameObject name.
        Debug.Log("Hello: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object in a circle
        transform.position = new Vector3(Mathf.Sin(10f*Time.time), Mathf.Cos(10f*Time.time), 0);

    }
}
