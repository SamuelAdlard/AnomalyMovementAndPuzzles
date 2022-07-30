using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float pickUpRange = 6;
    public Transform pickUpPoint;
    public Rigidbody item;
    public LineRenderer lineRenderer;
    public bool holding = false;
    public float holdStrength = 5;
    bool justheld = false;
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && holding)
        {
            holding = false;
            justheld = true;
            lineRenderer.enabled = false;
        }

        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position,transform.forward, out hit, pickUpRange) && !holding && !justheld)
        {
            print("hit");
            if (hit.transform.GetComponent<Item>())
            {
                print("hit object");
                item = hit.transform.GetComponent<Rigidbody>();
                holding = true;
            }

            
        }
        justheld = false;



        if (holding)
        {
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, pickUpPoint.position);
            lineRenderer.SetPosition(1, item.position);
            Vector3 targetVector = pickUpPoint.position - item.position;
            item.AddForce(targetVector * holdStrength);
        }
        
    }
}
