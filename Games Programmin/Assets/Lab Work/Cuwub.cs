using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cuwub : MonoBehaviour
{
    public GameObject cube2;
    public GameObject cube1;
    private bool lerp;
    public bool first;
    public bool second;

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            lerp = true;
        }

        if (lerp && first)
        {
         //   gameObject.transform.rotation = Quaternion.Slerp(cube1.transform.rotation, cube2.transform.rotation, 0.01f);
            gameObject.transform.position = Vector3.Lerp(cube1.transform.position, cube2.transform.position, 0.01f);
            gameObject.transform.rotation = Quaternion.Slerp(cube1.transform.rotation, cube2.transform.rotation, 0.01f);
            gameObject.transform.rotation =
                Quaternion.Slerp(cube1.transform.rotation, cube2.transform.rotation, Time.time * 1);
        }

        if (second)
        {
            cube1.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(cube1.transform.position,cube2.transform.position,3,3));
               // Vector3.RotateTowards(cube1.transform.rotation,cube2.transform.position,3,3);
        }
    }
}
