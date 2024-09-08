using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCOrder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit NPC");
        if (Input.GetKeyDown("space"))
            Debug.Log("Pressing E");
    }
}
