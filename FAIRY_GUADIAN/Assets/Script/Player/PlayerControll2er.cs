using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private int count;  // 強化回数
    public float strength = 1;  // 初期パワー
    public float speed = 0.07f; // 初速度
    public float AddSpeed = 1;  // 加速
    Rigidbody2D rigid2D;
    float xLimit = 8.3f;    // 横の最大範囲
    float yLimit = 4.3f;    // 縦の最大範囲
    BarrierDirector barrierDirector;
    BoxCollider2D boxCol;
    private float sizeCount =1.0f;  // 当たり判定の大きさ

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        count = 0;
        barrierDirector = GetComponent<BarrierDirector>();
        boxCol = GetComponent<BoxCollider2D>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); // デフォルトが右向きの画像の場合
        Vector3 scale = transform.localScale; // スケール値取り出し
        // ←が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * AddSpeed, 0, 0); // 左に1動かす
            scale.x = -4.0f; // 反転する（左向き）

            animator.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Run", false);
        }

        transform.localScale = scale; // 代入し直す

        // →が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {   
            transform.Translate(speed * AddSpeed, 0, 0); // 右に1動かす
            scale.x = 4.0f; // そのまま（右向き）

            animator.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Run", false);
        }

        transform.localScale = scale; // 代入し直す

        // ↑が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * AddSpeed, 0); // 上に1動かす

            animator.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("Run", false);
        }

        // ↓が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * AddSpeed, 0); // 下に1動かす

            animator.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Run", false);
        }

        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -xLimit, xLimit);    // 横の範囲制限
        playerPos.y = Mathf.Clamp(playerPos.y, -4.7f, yLimit);      // 縦の範囲制限
        transform.position = playerPos;

        // Qが押された時
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(count < 5)       // 5回まで
            {
                Debug.Log(sizeCount);
                strength += 5;     // 攻撃力が5上がる
                AddSpeed += 1.2f;      // 速度が1.2上がる
                sizeCount += 0.5f;  // 当たり判定が0.5大きくなる
                count++;
                boxCol.size = new Vector2(sizeCount, sizeCount);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            BarrierDirector.barrierHp += 5;     // バリアのHp回復
            Debug.Log(BarrierDirector.barrierHp);
        }
    }
   
}



