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
        //    HIT.enabled = true;  // Box Collider2D��L���ɂ���
        //}
        if (enemyHp <= 0)
        {
            expBarScript.nowexp += 150;
            this.gameObject.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        //if (HIT.enabled == true)  // Box Collider2D���L���̎� �@
        //{
        //    timer++;        // timer���J�E���g����
        //}
        //if (timer > 30)
        //{
        //    timer = 0;      // timer��0�ɖ߂�
        //    HIT.enabled = false;�@�@// Box Collider2D�𖳌��ɂ���
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
                // HIT.enabled = false;    // Box Collider2D�𖳌��ɂ���
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }

    }
}

