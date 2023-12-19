using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raingenerator : MonoBehaviour
{
    public GameObject rainPrefab;
    public GameObject player;

    float span = 0.1f;
    float delta = 0;
    float cloudx;
    float cloudy;
    int speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        cloudy = player.transform.position.y+ 4;
        cloudx = player.transform.position.x - 7;
        transform.position = new Vector2(cloudx, cloudy);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            this.delta = 0;
            float rx = Random.Range(transform.position.x, transform.position.x + 1);
            GameObject go = Instantiate(rainPrefab);
            go.GetComponent<raincontroller>().player = player;
            go.transform.position = new Vector2(rx, transform.position.y);
        }
        cloudx += 3f * Time.deltaTime;
        transform.position = new Vector2(cloudx , cloudy);

        if(transform.position.x < player.transform.position.x - 20)
        {
            Destroy(gameObject);
        }
        
    }
}
