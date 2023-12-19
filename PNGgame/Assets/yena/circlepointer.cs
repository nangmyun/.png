using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class circlepointer : MonoBehaviour
{
    public GameObject circle;
    public GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = circle.transform.position.x;
        float y = circle.transform.position.y;

        float mx = map.transform.position.x;
        float my = map.transform.position.y;

        transform.position = new Vector2(mx + x, my + y);
       // Debug.Log(mx + " " + my);

    }
}
