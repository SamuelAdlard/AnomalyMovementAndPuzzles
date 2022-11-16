using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airpuzzle : MonoBehaviour
{
    public GameObject Gift;

    [SerializeField] List<Switch> switches = new List<Switch>();
    [SerializeField]bool[] combination = new bool[5];
    [SerializeField]bool[] currentSetting = new bool[5];
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
        {
            //print(hitInfo.transform.name);
            if (hitInfo.transform.CompareTag("Switch"))
            {
                switches[int.Parse(hitInfo.transform.name)].Off.SetActive(false);
                switches[int.Parse(hitInfo.transform.name)].On.SetActive(true);
                switches[int.Parse(hitInfo.transform.name)].isOn = true;
                currentSetting[int.Parse(hitInfo.transform.name)] = switches[int.Parse(hitInfo.transform.name)].isOn;
            }
        }

        if (CompareArray())
        {
            print("VALID");
            Gift.SetActive(true);
        }
    }

    bool CompareArray()
    {
        for (int i = 0; i <= 4; i++)
        {
            if (combination[i] != currentSetting[i])
            {
                return false;
            }
        }
        return true;
    }


    [System.Serializable]public class Switch
    {
        public GameObject Off;
        public GameObject On;
        public bool isOn;
        public Switch(GameObject Off, GameObject On)
        {
            this.Off = Off;
            this.On = On;
        }
    }
}
