//https://blog.naver.com/chvj7567/222644765298

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class side : MonoBehaviour
{
    public GameObject player;
    public GameObject grey;
    public GameObject camera;
    public GameObject gauge;

    // Start is called before the first frame update
    int sidecheck = 1;
    bool greycheck = false;
    bool mobcheck = true;
    GameObject[] mob;
    void Start()
    {
        mob = GameObject.FindGameObjectsWithTag("Mob");
    }

    // Update is called once per frame
    void Update()
    {
        float px, py, pz;
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            greycheck = !greycheck; //��ο� ���� ����
            grey.SetActive(greycheck);

            mobcheck = !mobcheck;
            for(int i = 0; i < mob.Length; i++)
            {
                mob[i].SetActive(mobcheck);
            }


            px = player.transform.localPosition.x; //�÷��̾� ������ ��ȭ
            py = player.transform.localPosition.y;
            pz = player.transform.localPosition.z;
            player.transform.localPosition = new Vector3(-px, py, pz);

           

            sidecheck = -sidecheck; //������Ʈ ��ġ ��ȭ
            transform.localScale = new Vector3(sidecheck, 1, 1);
        }

        if (sidecheck == -1 && gauge.GetComponent<Image>().fillAmount > 0) //�̸��� ���
        {
            gauge.GetComponent<Image>().fillAmount -= 0.1f * Time.deltaTime;
            if(gauge.GetComponent<Image>().fillAmount == 0)
            {
                sidecheck = 1;
                greycheck = false;
                grey.SetActive(greycheck);
                transform.localScale = new Vector3(sidecheck, 1, 1);
            }
        }
        else if (sidecheck == 1 && gauge.GetComponent<Image>().fillAmount < 1)
        {
            gauge.GetComponent<Image>().fillAmount += 0.1f * Time.deltaTime;
        }

    }
}
