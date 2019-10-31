using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private int myNumber;

    // Start is called before the first frame update
    void Start()
    {
        // Message with a GameObject name.
        Debug.Log("Hello: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        Vector3 positionDelta = new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), Random.Range(-.1f, .1f));
        transform.Translate(positionDelta);
    }
}
