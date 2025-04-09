
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.RenderGraphModule;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    

    [SerializeField] int zPos = 50;
    [SerializeField] bool createSeg = false;
    [SerializeField] int segNum;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (createSeg==false)
        {
            createSeg = true;
            StartCoroutine(SegmentGen());
        }
        
    }

    IEnumerator SegmentGen()
    {
        segNum = Random.Range(0, 3);
        Instantiate(segment[segNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
       createSeg = false;
    }
}
