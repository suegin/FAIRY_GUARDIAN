using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc_Anim : MonoBehaviour
{
    GameObject Barrier;
    GameObject Fairy;
    private int count = 0;
    float speed = 0.01f;
    private Animator animator;
    private string Attack = "Attack";
    private string Walk = "Walk";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Barrier = GameObject.Find("Barrier");
        Fairy = GameObject.Find("Fairy");
    }

    // Update is called once per frame
    void Update()
    {

        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;
        if (a >= 2)
        {
            transform.position += new Vector3(x, y, transform.position.z);

        }
        else
        {
            animator.SetTrigger(Attack);
        }
        //if(/*ターゲットに近づいた時の条件*/)
        //{

        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    animator.SetTrigger(Attack);
        //}
        //if(Input.GetKeyDown(KeyCode.LeftAlt))
        //{
        //    animator.SetTrigger(Walk);
        //}

        
    }
}
