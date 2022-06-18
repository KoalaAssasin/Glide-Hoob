using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{

        public Camera mainCam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Code Taken from https://newbedev.com/csharp-unity-rotate-towards-mouse-2d-code-example

        //gets difference between player transform & in world location clicked
        Vector3 difference = mainCam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //Does something I don't understand, but it works so
        difference.Normalize();
        //Does some maths to get the rotation needed to face the direction of the mouse
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //Rotates the game object to face the mouse cursor
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z - 90);

    }
}
