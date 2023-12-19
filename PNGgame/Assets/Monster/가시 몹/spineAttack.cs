using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spineAttack : spineMobAttack
{
    float X, Y, front, present;
    int nt;
    
    // Start is called before the first frame update
    void Start()
    {
        X = spineMob_X;
        Y = spineMob_Y;
        front = spineMob_Front;
        nt = n;
        this.transform.position = new Vector2(X + front*nt*5, -5);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
