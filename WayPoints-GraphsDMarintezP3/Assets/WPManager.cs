using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    public enum direction { UNI, BI }
    public GameObject nodde1;
    public GameObject nodde2;
    public direction dir;
}
public class WPManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] waypoint;
    public Link[] links;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
