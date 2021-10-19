using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLights : MonoBehaviour
{
    public LightTimer script;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            script.enabled = true;
        }
    }

}
