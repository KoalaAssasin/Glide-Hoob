using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{

    public GameObject playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets camera to player position, but with a set Z value
        transform.position = new Vector3 (playerCharacter.transform.position.x, playerCharacter.transform.position.y, -10);
        
    }
}
