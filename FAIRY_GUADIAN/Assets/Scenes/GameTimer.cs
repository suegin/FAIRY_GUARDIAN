using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private float m_fTimer;
    public float CurrentTime { get { return m_fTimer; } }

    public bool m_bActive = false;

    private void Update()
    {
        if (m_bActive)
        {
            m_fTimer += Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            m_bActive = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            m_bActive = true;
        }

    }
}

