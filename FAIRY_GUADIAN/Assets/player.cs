using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    EnemyHp _eneHp;
    public Collider2D HIT;
    int timer;
    
    private void Start()
    {
        HIT.enabled = false;  // Box Collider2Dを無効にする
        // _eneHp = GameObject.Find("Enemy1").GetComponent<EnemyHp>();
        timer = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            HIT.enabled = true;  // Box Collider2Dを有効にする
            Debug.Log("HIT");
            
        }
    }
    private void FixedUpdate()
    {
        if(HIT.enabled == true)  // Box Collider2Dが有効の時 　
        {
            timer++;        // timerをカウントする
        }
        if (timer > 30)
        {
            timer = 0;      // timerを0に戻す
            HIT.enabled = false;　　// Box Collider2Dを無効にする
        }
    }

    // Update is called once per frame
    //public void OnTriggerStay2D(Collider2D collision)
    //{
    //   if(collision.gameObject.tag=="Enemy")
    //    {

    //        // _eneHp.enemyHp -= 1;
    //        // HIT.enabled = false;    // Box Collider2Dを無効にする
    //        Debug.Log("音が鳴る");
    //        GetComponent<AudioSource>().Play();
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

             // _eneHp.enemyHp -= 1;
             // HIT.enabled = false;    // Box Collider2Dを無効にする
            Debug.Log("音が鳴る");
            GetComponent<AudioSource>().Play();
        }
    }
}
