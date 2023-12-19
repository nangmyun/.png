using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public GameObject Player;
    public GameObject Hpbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hpbar.GetComponent<TextMeshProUGUI>().text = "HP: " + Player.GetComponent<PlayerController>().hp;
    }
}
