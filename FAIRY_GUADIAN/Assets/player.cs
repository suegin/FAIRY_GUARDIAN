using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D HIT;
    int timer;
    private void Start()
    {
        HIT.enabled = false;  // Box Collider2Dを無効化する
        timer = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HIT.enabled = true;  // Box Collider2Dを有効にする

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
            HIT.enabled = false;　　// Box Collider2Dを無効化する
        }
    }
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("1damage");
            HIT.enabled = false;　　// Box Collider2Dを無効化する
        }
            //  
       
        
    }
}
