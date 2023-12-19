using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{
    public float delta;
    int term;
    public GameObject player;
    public float speed;
    public int bossskill = 0;
    public int preskill = 0;
    public float jumpForce = 200f;
    bool jump = false;

    Animator animator;
    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    public GameObject cloudPrefab;
    public GameObject rainPrefab;

    void Start()
    {
        this.term = Random.Range(1, 3);
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > this.term && preskill == 0) //��ų�� ������� �ʾҰ� ���� �ƴٸ�
        {
            bossskill = Random.Range(1, 4);
            jump = false;
            this.delta = 0;
            term = Random.Range(5, 7);
            preskill = 1;
        }
        if (delta > this.term && preskill == 1) //��ų�� ����ϰ� ���� �ƴٸ�
        {
            bossskill = 0;
            this.delta = 0;
            term = Random.Range(1, 3);
            preskill = 0;
        }


        if (bossskill == 0)
        {
            
        }
        else if(bossskill == 1) //����
        {
            Debug.Log("����");
            this.animator.SetTrigger("SpinTrigger");
            transform.Translate(new Vector2(speed * Time.deltaTime, 0)); //�� �����̱� 
        }
        else if(bossskill == 2 &&!jump) //����
        {
            this.animator.SetTrigger("JumpTrigger");

            this.rigid2D.AddForce(transform.up * this.jumpForce);
            jump = true;
           
            
        }
        else if(bossskill == 3)
        {
            this.animator.SetTrigger("StickTrigger");
            if(1 < delta)
            {
                GameObject go = Instantiate(cloudPrefab);
                go.GetComponent<raingenerator>().player = player;
               
                bossskill = 0;
            }
        }

        if (transform.localPosition.x - player.transform.localPosition.x < 0) //�÷��̾ ������ �����ʿ� ���� ��
        {
            this.speed = 2;
        }
        else if (transform.localPosition.x - player.transform.localPosition.x > 0)
        {
            this.speed = -2;
        }
    }
}
