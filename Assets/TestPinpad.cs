using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPinpad : MonoBehaviour
{
    public int pinpad = 0;
    public List<int> PIN; 
    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //bool hitag1 = false;
        print(other.tag);
        if (other.CompareTag("Puzzle"))
        {
            string num = other.gameObject.name;
            int actaulNum = int.Parse(num);

            if (actaulNum == PIN[pinpad])
            {
               
                pinpad++;
                print("correct");
                if (PIN.Count == pinpad)
                {
                    print("Puzzle Solved!");
                    pinpad = 0;
                }
            }
            else
            {
                pinpad = 0;
                print("fail");
            }

        }
    }
}
