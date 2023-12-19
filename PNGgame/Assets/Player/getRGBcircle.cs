using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getRGBcircle : PlayerController
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mob"))
        {
            if(col.gameObject.GetComponent<mobBody>().RGB == 1)
            {
                r += 10;
                if(r > 100) r = 100;
            }
            else if(col.gameObject.GetComponent<mobBody>().RGB == 2)
            {
                g += 10;
                if(g > 100) g = 100;
            }
            else
            {
                b += 10;
                if(b > 100) b = 100;
            }
        }
        else if(col.CompareTag("Spine"))
        {
            b += 10;
            if(b > 100) b = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
