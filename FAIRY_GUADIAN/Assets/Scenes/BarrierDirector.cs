using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    public int barrierHp = 1000;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private int damageCoolTime = 0;
    // ダメージ量
    private int damage = 1;

    GameObject Enemy;

    EnhanceScript Damage;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("enemy");

        Damage = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
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

    // Enemyと接触している間
    void OnTriggerStay2D(Collider2D other)
    { 
        if (Damage.barrierDamage)
        {
            // バリアの耐久値が減る
            if (other.gameObject.tag == "Enemy")
            {
                //タイマーの計測
                damageCoolTime++;

                if (damageCoolTime < 2)
                {
                    barrierHp = barrierHp - damage;
                    Debug.Log(barrierHp);
                }
                else if (damageCoolTime > 25)
                {
                    damageCoolTime = 0;
                }
            }
        }
    }
}
