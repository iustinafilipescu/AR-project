using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DistanceBetweenTrackers : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    // Start is called before the first frame update
    void Start() 
    {
        float dist = Vector3.Distance(go1.transform.position, go2.transform.position);
        Debug.Log(string.Format("Distance between {0} and {1} is: {2}", go1, go2, dist));
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(go1.transform.position, go2.transform.position);
        Debug.Log(string.Format("Distance between {0} and {1} is: {2}", go1, go2, dist));
        if (dist<0.10)
        {
            go1.GetComponent<Animation>().Play("Attack");
            go2.GetComponent<Animation>().Play("Attack");
        }
        else
        {
            go1.GetComponent<Animation>().Play("Idle");
            go2.GetComponent<Animation>().Play("Idle");
        }
        
    }
}
