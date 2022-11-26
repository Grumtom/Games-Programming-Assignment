using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_9_script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotate(float dist)
    {
        gameObject.transform.rotation = Quaternion.Euler(dist * 360, 0, 0);
    }

    public void move(float dist)
    {
        gameObject.transform.position = new Vector3(dist*20 - 10,10,10);
    }
}
