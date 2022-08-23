using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour
{
    void Update()
    {

        RaycastHit interactionInfo;

        if (Physics.Raycast(transform.position, transform.forward, out interactionInfo, 100f))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;

            if(interactedObject.tag == "InteractableObject")
            {
                //interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
                print("hit");
            }
            else
            {
                //playerAgent.destination = interactionInfo.point;
            }
        }
    }
}
