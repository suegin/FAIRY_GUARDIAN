using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int enemyHp = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemyHp < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
