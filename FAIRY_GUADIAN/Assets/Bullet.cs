using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float fMoveSpeed = 7.0f;  // 移動値
    Vector3 bulletPoint;                // 弾の位置
    public float MoveSpeed = 20.0f;         // 移動値
    int frameCount = 0;             // フレームカウント
    const int deleteFrame = 180;    // 削除フレーム


    // 追加
    public GameObject BulletObj;     // 弾のゲームオブジェクト
    // Start is called before the first frame update
    void Start()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;
        Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // ボタンを押したとき
        if (Input.GetButtonDown("Fire1"))
        {
            // 弾の生成
            Instantiate(BulletObj);
        }

        // 位置の更新
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);

        // 一定フレームで消す
        if (++frameCount > deleteFrame)
        {
            Destroy(gameObject);
        }
    }
}
