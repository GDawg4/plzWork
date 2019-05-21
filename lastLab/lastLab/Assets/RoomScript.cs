using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    Light redLight;
    // Start is called before the first frame update
    void Start()
    {
        redLight = GetComponent<Light>();
        redLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (redLight.enabled)
        {
            redLight.intensity = 50 * Mathf.Sin(Time.time * 2) + 3;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController" || other.gameObject.name == "FirstPersonCharacter")
        {
            Debug.Log("Hes in the room");
            redLight.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "FPSController" || other.gameObject.name == "FirstPersonCharacter")
        {
            Debug.Log("Not Anymore");
            redLight.enabled = false;
        }
    }
}
