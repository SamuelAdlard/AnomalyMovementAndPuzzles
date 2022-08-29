using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class WorldInteraction : MonoBehaviour
{
    public TextMeshProUGUI PressF;
    public TextMeshProUGUI name;
    public int corruptionLevel = 1;
    bool startedConversation = false;
    int index = 0;
    void Update()
    {
        RaycastHit interactionInfo;        

        
        if (Physics.Raycast(transform.position, transform.forward, out interactionInfo, 2f)  )
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if (!startedConversation)
            {
                if (interactedObject.tag == "InteractableObject")
                {
                    name.text = interactedObject.GetComponent<NPC>().name;

                    PressF.text = "Press F";
                    if (Input.GetKey(KeyCode.F))
                    {

                        startedConversation = true;
                        
                    }
                }
                else
                {
                    PressF.text = "";
                }

            }

        }
        else if(!startedConversation)
        {
            PressF.text = "";
            name.text = "";
        }
        else
        {
            startedConversation = false;
            index = 0;
        }


        if (Input.GetKeyDown(KeyCode.F) && startedConversation)
        {


            if (Talk(index, interactionInfo))
            {
                index++;
            }
            else
            {
                startedConversation = false;
                index = 0;
            }
            
           
        }
    }

    bool Talk(int indexForConversation, RaycastHit hit)
    {
        
        if (index < hit.transform.GetComponent<NPC>().PickConversation(corruptionLevel).Length)
        {
            PressF.text = hit.transform.GetComponent<NPC>().PickConversation(corruptionLevel)[index];
            print(index);
            return true;
        }
        else
        {
            print("End");
            return false;
        }
        
    }
}
