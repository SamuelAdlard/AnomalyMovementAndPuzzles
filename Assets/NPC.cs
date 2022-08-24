using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public Conversation[] conversations;
    public string[] playerConversation;
    int corruptionLevel = 0;
  

}

public class Conversation
{
    public string[] conversation;
    Conversation(string[] conversation)
    {
        this.conversation = conversation;
    }
}