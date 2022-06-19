using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTextureNo;
    public Texture2D cursorTextureGrapple;

    public CursorMode cursorMode;
    public CursorLockMode lockMode;
    public Vector2 hotspot = Vector2.zero;

    public Camera mainCam;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorTextureNo, hotspot, cursorMode);
        Cursor.lockState = lockMode;
    }

    // Update is called once per frame
    void Update()
    {
                    //Raycast from click point
            RaycastHit2D hit = Physics2D.Raycast(mainCam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Grappleable"){
                    Cursor.SetCursor(cursorTextureGrapple, hotspot, cursorMode);
                }
                else
                {
                    Cursor.SetCursor(cursorTextureNo, hotspot, cursorMode);
                }
            }
            else{
                Cursor.SetCursor(cursorTextureNo, hotspot, cursorMode);
            }
    }
}
