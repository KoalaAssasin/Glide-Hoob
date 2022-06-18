using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_Temp : MonoBehaviour
{
    Vector2 mousePos;
    Vector3 worldPos;
    
    Vector3 destinationPos;

    public Rigidbody2D rb2D;

    public Camera mainCam;
    public GameObject playerCharacter;

    private Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Gets the in-game location of where the mouse is pointing to
        worldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        //Changes the playercharacter rotation to face in the direction of the mouse
        transform.LookAt(worldPos-transform.position, Vector3.back);

        //locks the X and Y rotations to keep the sprite flat
        transform.rotation = new Quaternion(0.0f, 0.0f, transform.rotation.z, transform.rotation.w);

    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            
        }
        if(Input.GetButton("Fire1"))
        {
            destinationPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            rb2D.AddForce((destinationPos-transform.position)*Time.fixedDeltaTime*10, ForceMode2D.Force);
        }
    }
}
