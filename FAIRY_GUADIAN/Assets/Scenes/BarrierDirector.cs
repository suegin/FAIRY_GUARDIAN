using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    public int barrierHp = 10;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private int damageCoolTime = 0;
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
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void FixedUpdate()
    {
        
    }

    // Enemyと接触している間
    void OnTriggerStay2D(Collider2D other)
    { 

        // バリアの耐久値が減る
        if (other.gameObject.tag == "Enemy")
        {
            //タイマーの計測
            damageCoolTime++;

            if (damageCoolTime < 2)
            {
                barrierHp = barrierHp = damage;
                Debug.Log("ダメージ！");

            }
            else if(damageCoolTime > 250)
            {
                damageCoolTime = 0;
            }
        }
            
    }
}
