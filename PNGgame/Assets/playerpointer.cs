using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerpointer : MonoBehaviour
{
    public GameObject player;
    public GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        float y = player.transform.position.y;

        float mx = map.transform.position.x;
        float my = map.transform.position.y;

        transform.position = new Vector2(mx + x*5, my + y*5);
        //Debug.Log(mx + " " + my);

    }
}
