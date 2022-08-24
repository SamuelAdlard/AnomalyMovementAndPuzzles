using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class WorldInteraction : MonoBehaviour
{
    public TextMeshProUGUI PressF;
    
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
        //index < hit.transform.GetComponent<NPC>().npcConversation.Length
        if (true)
        {
            //PressF.text = hit.transform.GetComponent<NPC>().npcConversation[index];
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
