using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
    public const float m_fStartTime = 300;
    public string m_strFormat;
    public GameTimer m_gameTimer;
    public static int fShowTime_Second;
    public static int fShowTime_Minits;

    private Text m_txt;

    private void Start()
    {
        m_txt = GetComponent<Text>();
        m_gameTimer = this.gameObject.GetComponent<GameTimer>();

    }

    private void FixedUpdate()
    {
        fShowTime_Second = (int)(m_fStartTime - m_gameTimer.CurrentTime) % 60;
        fShowTime_Minits = (int)(m_fStartTime - m_gameTimer.CurrentTime) / 60;

        m_txt.text = string.Format(m_strFormat, fShowTime_Minits.ToString() + ":" + fShowTime_Second.ToString());
        if (fShowTime_Minits <= 0 & fShowTime_Second <= 0)
        {
            SceneManager.LoadScene("Clear Scene");
        }
    }
}