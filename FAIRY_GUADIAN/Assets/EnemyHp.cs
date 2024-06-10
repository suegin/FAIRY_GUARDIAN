using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int enemyHp = 5;
    // public Collider2D HIT;
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        // HIT.enabled = false;
        // timer = 0;
    }

    // Update is called once per frame

    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    HIT.enabled = true;  // Box Collider2Dを有効にする
        //}
        if (enemyHp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        //if (HIT.enabled == true)  // Box Collider2Dが有効の時 　
        //{
        //    timer++;        // timerをカウントする
        //}
        //if (timer > 30)
        //{
        //    timer = 0;      // timerを0に戻す
        //    HIT.enabled = false;　　// Box Collider2Dを無効にする
        //}
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemyHp -= 1;
            Debug.Log(enemyHp);
            // HIT.enabled = false;    // Box Collider2Dを無効にする
        }

    }
}
