using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SectionTrigger : MonoBehaviour
{

    public GameObject RoadSectionTrigger;
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(RoadSectionTrigger, new Vector3(0, 0, -57), Quaternion.identity);
        }
    }
    

    
}
