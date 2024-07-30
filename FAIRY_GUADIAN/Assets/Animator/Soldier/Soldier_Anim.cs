using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Unity.Burst.CompilerServices;

public class Soldier_Anim : MonoBehaviour
{
    GameObject Barrier;
    GameObject Fairy;
    private int count = 0;
    float speed = 0.01f;
    private Animator animator;
    private string Attack = "Attack";
    private string Walk = "Walk";
    public int enemyHp = 7;
    private int damageCoolTime = 0;
    ExpBarScript expBarScript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Barrier = GameObject.Find("Barrier");
        Fairy = GameObject.Find("Fairy");
        //   expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();
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
    }
    public void OnTriggerStay2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            damageCoolTime++;
            if (damageCoolTime < 2)
            {
                enemyHp -= 1;
                Debug.Log(enemyHp);
                // HIT.enabled = false;    // Box Collider2D‚ð–³Œø‚É‚·‚é
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }
        if (enemyHp <= 0)
        {
            //expBarScript.nowexp += 150;
            //this.gameObject.SetActive(false);
        }

    }

}
