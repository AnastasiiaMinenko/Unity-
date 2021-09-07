using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCubes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] firstCubeGroup;
    public GameObject[] secondCubeGroup;
    public ActivateCubes button;
    public Material normal, transparent;
    public bool canPush;

    private void OnTriggerEnter(Collider other)
    {
        if (canPush)
        {
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject first in firstCubeGroup)
                {
                    first.GetComponent<Renderer>().material = normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }
                foreach (GameObject second in secondCubeGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = transparent;
                button.GetComponent<Renderer>().material = normal;
                button.canPush = true;
            }
        }        
    }
}
