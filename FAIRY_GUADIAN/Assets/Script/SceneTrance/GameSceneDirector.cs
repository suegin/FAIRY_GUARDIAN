using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneDirector : MonoBehaviour
{
    ChangeColorRGBA3 ChangeColorRGBA3;
    private Image FadeImage;
    bool is_loadClear = false;
    bool is_loadOver = false;
    Timer timer;
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA3 = GetComponent<ChangeColorRGBA3>();
        timer = GameObject.Find("GameTimer").gameObject.GetComponent<Timer>();
        Debug.Log(timer);
    }
    void Update()
    {

        if (timer.is_timeOver())
        {   
            is_loadClear = true;
            ChangeColorRGBA3.FadeoutOn();
        }

        if (BarrierDirector.barrierHp <= 0)
        {
            is_loadOver = true;
        }
    }

    public void LoadNextScene()
    {
        if (is_loadClear)
        {   
            is_loadClear = false;
            SceneManager.LoadScene("ClearScene");
        }
        if (is_loadOver)
        {
            is_loadOver = false;
            SceneManager.LoadScene("GameOverScene");
        }
    }
}