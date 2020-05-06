using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject reference;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -reference.transform.position.x/100, 0);
    }
}
