using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // バリアの耐久値
    private int barrierHp = 300;
    // 一度ダメージを食らったら一定時間ダメージを食らわないようにする
    private float damageCoolTime = 0f;
    // ダメージ量
    private int damage = 1;

    bool enemyHit = false;

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

    // Enemyと接触したら
    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("ダメージ！");
        if (other.gameObject.tag == "Enemy")
        {
            barrierHp -= 1;
            Debug.Log("ダメージ！");
        }
            
    }
}
