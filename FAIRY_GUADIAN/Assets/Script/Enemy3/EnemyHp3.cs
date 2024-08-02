using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp3 : MonoBehaviour
{
    public float enemyHp = 3;

    private int damageCoolTime = 0;

    ExpBarScript expBarScript;

    PlayerController damage;

    // Start is called before the first frame update
    void Start()
    {
        expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();

        damage = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame

    void Update()
    {
        if (enemyHp <= 0)
        {
            expBarScript.nowexp += 150;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    public void OnTriggerStay2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            damageCoolTime++;
            if (damageCoolTime < 2)
            {
                enemyHp -= damage.strength;
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }
    }
}

