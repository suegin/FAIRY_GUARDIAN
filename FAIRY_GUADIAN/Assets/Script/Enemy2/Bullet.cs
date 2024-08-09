using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject Fairy;

    int damageCoolTime;

    int damage = 1;

    BarrierDirector Hp;

    public GameObject enemy = null;

    // 弾の速度
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        Fairy = GameObject.Find("Fairy");

        Hp = GameObject.Find("barrier").GetComponent<BarrierDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 9.6f);

        float b = Fairy.transform.position.x - transform.position.x;
        float c = (Fairy.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Fairy.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Fairy.transform.position.y - transform.position.y;
        y = y / a * speed;

        float rotation = Mathf.Atan2(y, x) * Mathf.PI;

        transform.position += new Vector3(x, y, 0);

        this.transform.rotation = new Quaternion(0,0,rotation,0);

        //Debug.Log(rotation);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.0f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.01f;
        }

        if(enemy == null)
        {
            Destroy(this.gameObject);
        }
    }
        
    // 弾が消える処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Fairy" || collision.tag == "Barrier")
        {
            //タイマーの計測
            damageCoolTime++;

            if (damageCoolTime < 2)
            {
                BarrierDirector.barrierHp = BarrierDirector.barrierHp - damage;
                Debug.Log(BarrierDirector.barrierHp);
            }
            else if (damageCoolTime > 25)
            {
                damageCoolTime = 0;
            }

            Destroy(gameObject);
        }
    }
}
