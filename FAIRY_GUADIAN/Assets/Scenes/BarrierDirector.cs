using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    private int barrierHp = 100;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private float damageCoolTime = 0f;
    // ダメージ量
    private int damage = 1;

    GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        // 耐久値がなくなったら
        if (barrierHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Enemyと接触したら
    void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.CompareTag("Enemy"))
        {
            Debug.Log("ダメージ！");
            barrierHp -= damage;
        }
    }
}
