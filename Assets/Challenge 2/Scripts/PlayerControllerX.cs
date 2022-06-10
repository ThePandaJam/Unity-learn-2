using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float _sendRate = 0.7f;
    private float _canSend = -1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canSend)
        {
            SendDog();
        }
    }

    void SendDog()
    {
        _canSend = Time.time + _sendRate;
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
