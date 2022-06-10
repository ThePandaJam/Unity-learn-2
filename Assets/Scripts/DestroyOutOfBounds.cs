using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30f;

    private float bottomBoundary = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object is out of the game view, destroy it
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
