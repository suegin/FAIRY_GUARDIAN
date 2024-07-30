using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierDirector : MonoBehaviour
{
    // �o���A�̑ϋv�l
    public int barrierHp = 10;
    // ��x�_���[�W��H��������莞�ԃ_���[�W��H���Ȃ��悤�ɂ���
    private int damageCoolTime = 0;
    // �_���[�W��
    private int damage = 1;

    GameObject Enemy;

    EnhanceScript Damage;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.Find("enemy");

        Damage = GameObject.Find("Enhance").GetComponent<EnhanceScript>();
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

    // Enemy�ƐڐG���Ă����
    void OnTriggerStay2D(Collider2D other)
    { 
        if (Damage.barrierDamage)
        {
            // �o���A�̑ϋv�l������
            if (other.gameObject.tag == "Enemy")
            {
                //�^�C�}�[�̌v��
                damageCoolTime++;

                if (damageCoolTime < 2)
                {
                    barrierHp = barrierHp - damage;
                }
                else if (damageCoolTime > 25)
                {
                    damageCoolTime = 0;
                }
            }
        }
    }
}