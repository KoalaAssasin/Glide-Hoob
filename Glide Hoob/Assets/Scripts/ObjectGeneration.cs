using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGeneration : MonoBehaviour
{
    public Vector2 randomVector;
    public GameObject spawnObject;

    public Score scoreManager;

    void RespawnObject()
    {
        scoreManager.scoreNumber ++;
        bool canSpawn = false;
        while((canSpawn) == false)
        {
            randomVector = new Vector2(Random.Range(-130.0f, 130.0f), Random.Range(-130.0f, 130.0f));
            canSpawn = CheckClear(randomVector);
        }
        transform.position = new Vector2(randomVector.x, randomVector.y);

    }

    bool CheckClear(Vector2 SpawnLocation)
    {
        RaycastHit2D check = Physics2D.Raycast(SpawnLocation, Vector2.zero);
            if(check.collider == null)
            {
                return true;
            }
            else if (check.collider != null)
            {
                return false;
            }
        return false;
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "PlayerCharacter")
        {
            RespawnObject();
        }
    }

    void Start() {

        bool canSpawn = false;
        while((canSpawn) == false)
        {
            randomVector = new Vector2(Random.Range(-130.0f, 130.0f), Random.Range(-130.0f, 130.0f));
            canSpawn = CheckClear(randomVector);
        }
        transform.position = new Vector2(randomVector.x, randomVector.y);
    }

}
