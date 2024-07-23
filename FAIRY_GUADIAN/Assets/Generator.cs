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
            //�������G�l�~�[�̐����G�l�~�[�̍ő吔���������Ȃ�������
            if (ExistEnemyNum < kEnemyMaxNum)
            {
                if (Spawn.spawn)
                {
                    this.delta = 0;
                    //�G�l�~�[�̐���
                    GameObject go = Instantiate(enemy);
                    //�o�����G�l�~�[�̐���ۑ�
                    ExistEnemyNum++;
                    //�����̍쐬
                    int px = Random.Range(-12, 12);
                    int py = Random.Range(-14, 10);
                    //��ʓ��ŏo�����悤�Ƃ��Ă��邩�ǂ����̔���
                    bool isY = (py > -5 && py < 5);//x���W
                    bool isX = (px > -9 && px < 9);//y���W
                                                   //��ʓ��ŏo�����悤�Ƃ����ꍇ�A�O�ɏo���B
                    if (isX && isY)
                    {
                        py = Random.Range(5, 9);
                        px = Random.Range(-12, 12);
                    }

                    //�o���ʒu�̐ݒ�
                    go.transform.position = new Vector3(px, py, 0);
                }
            }
        }
    }
}
