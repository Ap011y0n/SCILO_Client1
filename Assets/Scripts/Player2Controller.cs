using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private GameObject clientObj;
    private Animator animator;
    int jumpAnimation;
    int shootAnimation;
    Vector3 lastPos;
    int frameCounter;

    // Start is called before the first frame update
    void Start()
    {
        clientObj = GameObject.Find("Client");
        animator = GetComponent<Animator>();
        jumpAnimation = Animator.StringToHash("Jump");
        shootAnimation = Animator.StringToHash("Shoot");
        frameCounter = 0;
        lastPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(frameCounter >= 5)
        {
            if (lastPos != this.transform.position)
            {
                Animate(this.transform.position);
            }
            else { animator.SetFloat("isWalking", 0.5f); }

            lastPos = this.transform.position;
            frameCounter = 0;
        }

        frameCounter++;*/
    }

    public void Animate(Vector3 pos)
    {
        if (pos.z > lastPos.z)
        {
            animator.SetFloat("isWalking", 1f);
        }
        else if(pos.z < lastPos.z)
        {
            animator.SetFloat("isWalking", 0f);
        }

        if(pos.y > lastPos.y)
        {
            animator.SetTrigger(jumpAnimation);
        }
    }
}
