using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    private int MaxHP
    {
        get
        {
            string tagName = this.gameObject.tag;

            if (tagName == "Enemy1")
            {
                return 3;
            }
            else if (tagName == "Enemy2")
            {
                return 6;
            }
            else if (tagName == "Enemy3")
            {
                return 10;
            }
            else if (tagName == "Enemy4")
            {
                return 15;
            }
            else
            {
                return 5;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        print(this.gameObject.tag);
        print(MaxHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
