using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D HIT;
    int timer;
    private void Start()
    {
        HIT = GetComponent<Collider2D>();
        HIT.enabled = false;  // Box Collider2D�𖳌��ɂ���
        timer = 0;
        
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            HIT.enabled = true;  // Box Collider2D��L���ɂ���
            
        }
    }
    private void FixedUpdate()
    {
        if (HIT.enabled == true)  // Box Collider2D���L���̎� �@
        {
            timer++;        // timer���J�E���g����
        }
        if (timer > 30)
        {
            timer = 0;      // timer��0�ɖ߂�
            HIT.enabled = false;�@�@// Box Collider2D�𖳌��ɂ���
        }
    }

    // Update is called once per frame
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
         {
             Destroy(collision.gameObject);
             HIT.enabled = false;    // Box Collider2D�𖳌��ɂ���
         }
    }
}
