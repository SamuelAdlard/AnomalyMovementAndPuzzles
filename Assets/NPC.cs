using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public string name;
    public string[] Conversation1;
    public string[] Response1;
    public string[] Conversation2;
    public string[] Response2;
    public string[] Conversation3;
    public string[] Response3;
    public string[] Conversation4;
    public string[] Response4;
    public string[] Conversation5;
    public string[] Response5;
    public string[] Conversation6;
    public string[] Response6;
    public string[] Conversation7;
    public string[] Response7;
    public string[] Conversation8;
    public string[] Response8;
    public string[] Conversation9;
    public string[] Response9;
    public string[] Conversation10;
    public string[] Response10;
    public string[] Conversation11;
    public string[] Response11;
    public string[] Conversation12;
    public string[] Response12;
    public string[] Conversation13;
    public string[] Response13;
    
    public string[] PickConversation(int corruptionLevel)
    {
        if(corruptionLevel == 1)
        {
            return Conversation1;
        }
        else if(corruptionLevel == 2)
        {
            return Conversation2;
        }
        else if(corruptionLevel == 3)
        {
            return Conversation3;
        }
        else if(corruptionLevel == 4)
        {
            return Conversation4;
        }
        else if(corruptionLevel == 5)
        {
            return Conversation5;
        }
        else if(corruptionLevel == 6)
        {
            return Conversation6;
        }
        else if(corruptionLevel == 7)
        {
            return Conversation7;
        }
        else if(corruptionLevel == 8)
        {
            return Conversation8;
        }
        else if(corruptionLevel == 9)
        {
            return Conversation9;
        }
        else if(corruptionLevel == 10)
        {
            return Conversation10;
        }
        else if(corruptionLevel == 11)
        {
            return Conversation11;
        }
        else if(corruptionLevel == 12)
        {
            return Conversation12;
        }

        return Conversation1;
    }

    public string[] PlayerResponses(int corruptionLevel)
    {
        if(corruptionLevel == 1)
        {
            return Response1;
        }
        else if(corruptionLevel == 2)
        {
            return Conversation2;
        }
        else if(corruptionLevel == 3)
        {
            return Conversation3;
        }
        else if(corruptionLevel == 4)
        {
            return Conversation4;
        }
        else if(corruptionLevel == 5)
        {
            return Conversation5;
        }
        else if(corruptionLevel == 6)
        {
            return Conversation6;
        }
        else if(corruptionLevel == 7)
        {
            return Conversation7;
        }
        else if(corruptionLevel == 8)
        {
            return Conversation8;
        }
        else if(corruptionLevel == 9)
        {
            return Conversation9;
        }
        else if(corruptionLevel == 10)
        {
            return Conversation10;
        }
        else if(corruptionLevel == 11)
        {
            return Conversation11;
        }
        else if(corruptionLevel == 12)
        {
            return Conversation12;
        }
        return Conversation1;
    }

}

