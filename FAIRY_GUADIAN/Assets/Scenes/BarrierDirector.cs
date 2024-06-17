using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // �o���A�̑ϋv�l
    private int barrierHp = 300;
    // ��x�_���[�W��H��������莞�ԃ_���[�W��H���Ȃ��悤�ɂ���
    private float damageCoolTime = 0f;
    // �_���[�W��
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
        // �ϋv�l���Ȃ��Ȃ�����
        if (barrierHp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void FixedUpdate()
    {
        
    }

    // Enemy�ƐڐG������
    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("�_���[�W�I");
        if (other.gameObject.tag == "Enemy")
        {
            barrierHp -= 1;
            Debug.Log("�_���[�W�I");
        }
            
    }
}
