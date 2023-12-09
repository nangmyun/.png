using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 400.0f, walkForce = 100.0f, maxWalkSpeed = 4.0f;
    float jumpTime, jumpTime2;
    bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping && this.rigid2D.velocity.y == 0) //점프
        {
            this.animator.SetTrigger("JumpTrigger");
            jumpTime = Time.time;
            isJumping = true;
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        if(Input.GetKey(KeyCode.Space) && isJumping) //누른 시간에 따라 점프 높이 조절
        {
            jumpTime2 = Time.time - jumpTime;
            this.rigid2D.AddForce(transform.up * this.jumpForce * jumpTime2 * 0.4f);
        }

        if((isJumping && jumpTime2 > 0.3f )|| Input.GetKeyUp(KeyCode.Space))
        {
            this.isJumping = false;
        }

        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(key != 0 && !isJumping && (this.rigid2D.velocity.y == 0 || this.rigid2D.velocity.x == 0))
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 4.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }
    }
}
