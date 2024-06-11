using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Text))]
public class ShowCountdown : MonoBehaviour
{
    public const float m_fStartTime = 300;
    public string m_strFormat;
    public GameTimer m_gameTimer;

    private Text m_txt;

    private void Start()
    {
        m_txt = GetComponent<Text>();
        m_gameTimer = GameObject.Find("GameTimer").GetComponent<GameTimer>();
    }

    private void Update()
    {
        int fShowTime_Second = (int)(m_fStartTime - m_gameTimer.CurrentTime) % 60;
        int fShowTime_Minits = (int)(m_fStartTime - m_gameTimer.CurrentTime) / 60;

        m_txt.text = string.Format(m_strFormat, fShowTime_Minits.ToString() + ":" + fShowTime_Second.ToString());
    }
}