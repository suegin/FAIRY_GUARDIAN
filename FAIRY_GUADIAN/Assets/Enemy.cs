using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 敵プレハブ
    public GameObject Enemy1Prefab;
    // 時間間隔の最小値
    public float minTime = 2f;
    // 時間間隔の最大値
    public float maxTime = 2f;
    // 敵生成時間間隔
    private float interval;
    // 経過時間
    private float time = 0f;
    GameObject Player;

    float speed = 0.005f;
    
    // Start is called before the first frame update
    void Start()
    {
        // 時間間隔を決定する
        //interval = GetRandomTime();
        // Fairyを追跡
        Player = GameObject.Find("Player");       
    }

    // Update is called once per frame
    void Update()
    {
        // 時間計測
        time += Time.deltaTime;

        // 経過時間が生成時間になったとき(生成時間より大きくなった時)
        if (time > interval)
        {
            // Enemyをインスタンス化する(生成する)
            GameObject Enemy1 = Instantiate(Enemy1Prefab);
            // 生成した敵の座標を決定する
            Enemy1.transform.position = new Vector3(-4.61f, -0.49f, 0);
            // 経過時間を初期化して再度時間計測を始める
            time = 0f;
            // 次に発生する時間間隔を決定する
            //interval = GetRandomTime();
        }



        // EnemyがFairyを追跡する
        float b = Player.transform.position.x - transform.position.x;
        float c = (Player.transform.position.y - transform.position.y);
            
        float dis = (b * b + c *c );
        float a=Mathf.Sqrt(dis);
        float x = Player.transform.position.x - transform.position.x;
        x= x/ a* speed;
        float y = Player.transform.position.y - transform.position.y;
        y = y / a* speed;
        transform.position += new Vector3(x, y, transform.position.z);

        Debug.Log(Player.transform.position);

     
    }

}
