using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCOrder : MonoBehaviour
{
    public GameObject orderGenerator;
    private bool hasContact = false;

    void Update()
    {
        if (hasContact && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressing E");
            UpdateCurrNumOfDelivery();  

        }
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hitting NPC");
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Contact True");
            hasContact = true;
        }
    }


    private void UpdateCurrNumOfDelivery()
    {
        float currNum = orderGenerator.GetComponent<OrderGenerator>().GetCurrNumOfDelivery();
        currNum += 1;
        orderGenerator.GetComponent<OrderGenerator>().SetCurrNumOfDelivery(currNum);
        orderGenerator.GetComponent<OrderGenerator>().UpdateDeliveryProgress();
    }

    private bool CheckOrder()
    {
        //If order is the right icecream flavor orderCorrect turns true
        // else false
        return false;
    }
}
