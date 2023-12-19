using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spineMobAttack : MonoBehaviour
{
    public GameObject Player, spinePrefab;
    Animator animator;
    public static float spineMob_X, spineMob_Y, spineMob_Front;
    public static int n;
    bool isAttack;
    // Start is called before the first frame update
    void Start()
    {
        isAttack = false;
        this.animator = GetComponent<Animator>();
    }

    void attack()
    {
        isAttack = false;
    }

    void spine()
    {
        n++;
        GameObject spines = Instantiate(spinePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x - Player.transform.localPosition.x > -5 && transform.localPosition.x - Player.transform.localPosition.x < 5 && !isAttack)
        {
            isAttack = true;
            n = 0;
            if(transform.localPosition.x - Player.transform.localPosition.x < 0) //몬스터가 플레이어의 오른쪽에 있을 때
            {
                spineMob_Front = 1.0f;
            }
            else
            {
                spineMob_Front = -1.0f;
            }
            spineMob_X = this.transform.position.x;
            spineMob_Y = this.transform.position.y;
            transform.localScale = new Vector3(-spineMob_Front*1.4f, 1.4f, 1);
            this.animator.SetTrigger("attackTrigger");
            Invoke("spine", 0.4f);
            Invoke("spine", 1.4f);
            Invoke("spine", 2.4f);
            Invoke("spine", 3.4f);
            Invoke("attack", 5.0f);
        }
    }
}
