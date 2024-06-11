using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    public int barrierHp = 10000;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private float damageCoolTime = 0f;
    // ダメージ量
    private int damage = 1;

    bool enemyHit = false;

    GameObject Enemy = null;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        // 耐久値がなくなったら
        if (barrierHp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void FixedUpdate()
    {
        
    }

    // Enemyと接触したら
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            barrierHp -= 1;
            Debug.Log("ダメージ！");
        }
    }
}
