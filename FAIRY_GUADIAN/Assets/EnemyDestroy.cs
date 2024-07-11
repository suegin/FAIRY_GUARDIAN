using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D HIT;
    int timer;
    private void Start()
    {
        HIT = GetComponent<Collider2D>();
        HIT.enabled = false;  // Box Collider2Dを無効にする
        timer = 0;
        
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            HIT.enabled = true;  // Box Collider2Dを有効にする
            
        }
    }
    private void FixedUpdate()
    {
        if (HIT.enabled == true)  // Box Collider2Dが有効の時 　
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
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
         {
             Destroy(collision.gameObject);
             HIT.enabled = false;    // Box Collider2Dを無効にする
         }
    }
}
