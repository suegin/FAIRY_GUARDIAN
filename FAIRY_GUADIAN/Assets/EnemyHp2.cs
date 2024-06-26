using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp2 : MonoBehaviour
{
    public int enemyHp = 5;
    // public Collider2D HIT;
    private int damageCoolTime = 0;

    ExpBarScript expBarScript;
    // Start is called before the first frame update
    void Start()
    {
     //   expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            expBarScript.nowexp += 150;
            this.gameObject.SetActive(false);
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
            else if (damageCoolTime > 250)
            {
                damageCoolTime = 0;
            }
        }

    }
}
