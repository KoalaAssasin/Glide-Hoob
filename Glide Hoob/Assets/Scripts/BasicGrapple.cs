using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGrapple : MonoBehaviour
{
    Vector3 destinationPos;

    public Rigidbody2D rb2D;
    public TargetJoint2D tJ2D;

    public Camera mainCam;

    //TODO: When the distance between the anchor and target is beneath a certain amount,
    //sets the target to stay with the anchor on update until target is relocated
    //on mouse click.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Converts the point clicked on screen into an in-world position
            destinationPos = mainCam.ScreenToWorldPoint(Input.mousePosition);

            //Sets the Target attribute of the target joint component to the location clicked
            tJ2D.target = destinationPos;
        }
    }

}
