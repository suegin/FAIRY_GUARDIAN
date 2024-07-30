using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using Unity.Burst.CompilerServices;

public class Fire_Anim : MonoBehaviour
{
    GameObject Barrier;
    GameObject Fairy;
    private int count = 0;
    float speed = 0.01f;
    private Animator animator;
    private string Attack = "Attack";
    private string Walk = "Walk";
    public int enemyHp = 7;
    private int damageCoolTime = 0;
    ExpBarScript expBarScript;
    EnhanceScript shot;
    public GameObject m_shot;// ショットの弾


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Barrier = GameObject.Find("Barrier");
        Fairy = GameObject.Find("Fairy");
        shot = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
        //   expBarScript = GameObject.Find("exp").GetComponent<ExpBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;
        if (a >= 5)
        {
            transform.position += new Vector3(x, y, transform.position.z);

        }
        else
        {
            if (shot.shot)
            {
                Shot();
                Debug.Log("あ");
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.005f;
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
                // HIT.enabled = false;    // Box Collider2Dを無効にする
            }
            else if (damageCoolTime > 4)
            {
                damageCoolTime = 0;
            }
        }
        if (enemyHp <= 0)
        {
            //expBarScript.nowexp += 150;
            //this.gameObject.SetActive(false);
        }

    }
    private void Shot()
    {
        count += 1;

        // 120フレームごとに砲弾を発射する
        if (count % 120 == 0)
        {
            // 弾のインスタンス生成を行う
            GameObject shell = Instantiate(m_shot, transform.position, Quaternion.identity);
            shell.GetComponent<Bullet>().enemy = this.gameObject;
        }
    }

}
