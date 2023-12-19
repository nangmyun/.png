using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossgenerator : MonoBehaviour
{
    public GameObject starPrefab;
    public GameObject boss;
    public GameObject player;
    float span = 10f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            this.delta = 0;
            starPrefab.GetComponent<mobmove>().player = player;
            GameObject go = Instantiate(starPrefab);
            float px = boss.transform.position.x;
            go.transform.position = new Vector2(px, boss.transform.position.y + 4);
        }
    }
}
