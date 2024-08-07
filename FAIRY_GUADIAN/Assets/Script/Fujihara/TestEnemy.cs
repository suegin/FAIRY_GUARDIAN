using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Testenemy : MonoBehaviour
{

    GameObject Barrier;

    public float speed = 0.005f;

    int hp = 5;

    

    // Start is called before the first frame update
    void Start()
    {

        // Fairyを追跡
        Barrier = GameObject.Find("Barrier");
    }

    // Update is called once per frame
    void Update()
    {
        
        // EnemyがFairyを追跡する
        float b = Barrier.transform.position.x - transform.position.x;
        float c = (Barrier.transform.position.y - transform.position.y);

        float dis = (b * b + c * c);
        float a = Mathf.Sqrt(dis);
        float x = Barrier.transform.position.x - transform.position.x;
        x = x / a * speed;
        float y = Barrier.transform.position.y - transform.position.y;
        y = y / a * speed;
        transform.position += new Vector3(x, y, transform.position.z);
    }

    // バリアと接触している間
    void OnTriggerStay2D(Collider2D other)
    {
        // 動きを止める
        if (other.gameObject.tag == "Barrier")
        {
            // Debug.Log("あ");
            speed = 0.000001f;
        }
    }
}
