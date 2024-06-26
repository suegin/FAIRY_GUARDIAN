using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp4 : MonoBehaviour
{
    public int enemyHp = 3;
    // public Collider2D HIT;
    private int damageCoolTime = 0;

    ExpBarScript expBarScript;

    // Start is called before the first frame update
    void Start()
    {
        // HIT.enabled = false;
        // timer = 0;

       // expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();

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
            expBarScript.nowexp += 150;
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

    public void OnTriggerStay2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            damageCoolTime++;
            if (damageCoolTime < 2)
            {
                enemyHp -= 1;
                Debug.Log(enemyHp);
                // HIT.enabled = false;    // Box Collider2Dを無効にする
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }

    }
}

