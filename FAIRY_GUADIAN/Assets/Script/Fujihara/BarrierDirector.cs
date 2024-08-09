using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    public static int barrierHp = 10;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private int damageCoolTime = 0;
    // ダメージ量
    private int damage = 1;

    GameObject Enemy;

    EnhanceScript Damage;

    // Start is called before the first frame update
    void Start()
    {
        barrierHp = 10;

        Enemy = GameObject.Find("enemy");

        Damage = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
    }

    // Update is called once per frame
    void Update()
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
                   // Debug.Log(barrierHp);
                }
                else if (damageCoolTime > 25)
                {
                    damageCoolTime = 0;
                }
            }
        }
    }
}
