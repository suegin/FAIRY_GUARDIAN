using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneDirector : MonoBehaviour
{
    ChangeColorRGBA3 ChangeColorRGBA3;
    private Image FadeImage;
    void Start()
    {
        FadeImage = GetComponent<Image>();
        ChangeColorRGBA3 = GetComponent<ChangeColorRGBA3>();
    }
    void Update()
    {

        if (Timer.fShowTime_Minits <= 0 & Timer.fShowTime_Second <= 0)
        {   
            ChangeColorRGBA3.FadeoutOn();
            ChangeColorRGBA3.Update();
        }

        // �o���A����ꂽ��V�[���J�ڂ�����

    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}