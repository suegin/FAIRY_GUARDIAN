using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private int count;
    public float _strength = 1;
    float AddSpeed = 1;
    Rigidbody2D rigid2D;
    float xLimit = 8.3f;
    float yLimit = 4.3f;
    BarrierDirector barrierDirector;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        count = 0;
        barrierDirector = GetComponent<BarrierDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); // デフォルトが右向きの画像の場合
        Vector3 scale = transform.localScale; // スケール値取り出し
        // ←が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.07f * AddSpeed, 0, 0); // 左に1動かす
            scale.x = -0.1f; // 反転する（左向き）
            
        }
        transform.localScale = scale; // 代入し直す

        // →が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(0.07f * AddSpeed, 0, 0); // 右に1動かす
            scale.x = 0.1f; // そのまま（右向き）
        }
        transform.localScale = scale; // 代入し直す

        // ↑が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.07f * AddSpeed, 0); // 上に1動かす
            
        }

        // ↓が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.07f * AddSpeed, 0); // 下に1動かす
        }

        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -xLimit, xLimit);
        playerPos.y = Mathf.Clamp(playerPos.y, -4.7f, yLimit);
        transform.position = playerPos;

        // Qが押された時
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(count < 5)       // 5回まで
            {
                _strength += 5;     // 攻撃力が5上がる
                AddSpeed += 1.2f;      // 速度が1.2上がる
                count += 1;
                Debug.Log(count);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            barrierDirector.barrierHp += 5;
            Debug.Log(barrierDirector.barrierHp);
        }

    }
   
}



