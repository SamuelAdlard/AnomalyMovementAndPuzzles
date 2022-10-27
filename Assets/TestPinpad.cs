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

            if (num == "1")
            {

                if (PIN[pinpad] == 1)
                {
                    // hitag1 = true;
                    pinpad++;
                    print(PIN[pinpad]);
                }
                else
                {
                    pinpad = 0;
                    print("fail");
                }
            }

            else if (num == "2")
            {
                if (PIN[pinpad] == 2)
                {
                    pinpad++;

                }
                else
                {
                    pinpad = 0;
                    print("fail");
                }
            }
            else if (num == "3")
            {
                if (PIN[pinpad] == 3)
                {
                    pinpad++;
                    print("you have solved the puzzle!");
                }
                else
                {
                    pinpad = 0;
                    print("fail");
                }
            }
        }
    }
}
