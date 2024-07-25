using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp2 : MonoBehaviour
{
    public int enemyHp = 5;

    private int damageCoolTime = 0;

    ExpBarScript expBarScript;

    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            expBarScript.nowexp += 150;
            // this.gameObject.SetActive(false);
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
                enemyHp -= 1;
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }
    }
}
