using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGrapple : MonoBehaviour
{
    Vector3 destinationPos;

    public bool canGrapple;

    public Rigidbody2D rb2D;
    public TargetJoint2D tJ2D;

    public LineRenderer lR;
    public float grappleDistance;

    public Camera mainCam;

    //When the distance between the anchor and target is beneath a certain amount,
    //disables the joint and line render until target is relocated
    //on mouse click.
    void LetLoose()
    {
        tJ2D.enabled = false;
        lR.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Raycast from click point
            RaycastHit2D hit = Physics2D.Raycast(mainCam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Grappleable"){
                    canGrapple = true;
                }
                else
                {
                    canGrapple = false;
                }
            }

            if(canGrapple == true){
                //Converts the point clicked on screen into an in-world position
                destinationPos = mainCam.ScreenToWorldPoint(Input.mousePosition);

                tJ2D.enabled = true;
                lR.enabled = true;
                //Sets the Target attribute of the target joint component to the location clicked
                tJ2D.target = destinationPos;
                canGrapple = false;
            }

        }

        //Checks the distance between the anchor and target for the grapple
        //I used the Line renderer points to measure it because the target joint
        //Vectors get pretty wonky between local and world mode, and it did all sorts
        //of funky stuff when I used that
        grappleDistance = (lR.GetPosition(0) - lR.GetPosition(1)).magnitude;

        if(tJ2D.enabled == true && grappleDistance < 1)
        {
            LetLoose();
        }
    }

}
