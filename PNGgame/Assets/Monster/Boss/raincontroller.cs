using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raincontroller : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float px = player.transform.position.x;
        if (player.transform.position.y - 7 > transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
