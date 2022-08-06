using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.transform.position = player.position;
    }
}
