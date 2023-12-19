using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fda : MonoBehaviour
{
    private GameObject currentTeleporter;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<portal>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerEnterExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}