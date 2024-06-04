using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    private int hp = 15;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private float damageCoolTime = 0f;
    // ダメージ量
    private int damage = 1;

    bool enemyHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // 耐久値がなくなったら
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage()
    {
        hp--;
    }
}
