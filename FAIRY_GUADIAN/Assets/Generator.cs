using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private int kEnemyMaxNum;

    int ExistEnemyNum = 0;

    const int StageTime = 300;

    int EnemySpan = 0;
    public GameObject enemy;
    [SerializeField] float span = 1.0f;
    float delta = 0;
    int num;

    EnhanceScript Spawn;

    // Start is called before the first frame update
    void Start()
    {
        Spawn = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            //だしたエネミーの数がエネミーの最大数よりもすくなかったら
            if (ExistEnemyNum < kEnemyMaxNum)
            {
                if (Spawn.spawn)
                {
                    this.delta = 0;
                    //エネミーの生成
                    GameObject go = Instantiate(enemy);
                    //出したエネミーの数を保存
                    ExistEnemyNum++;
                    //乱数の作成
                    int px = Random.Range(-12, 12);
                    int py = Random.Range(-14, 10);
                    //画面内で出現しようとしているかどうかの判定
                    bool isY = (py > -5 && py < 5);//x座標
                    bool isX = (px > -9 && px < 9);//y座標
                                                   //画面内で出現しようとした場合、外に出す。
                    if (isX && isY)
                    {
                        py = Random.Range(5, 9);
                        px = Random.Range(-12, 12);
                    }

                    //出現位置の設定
                    go.transform.position = new Vector3(px, py, 0);
                }
            }
        }
    }
}
