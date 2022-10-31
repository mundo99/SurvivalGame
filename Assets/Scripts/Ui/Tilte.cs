using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tilte : MonoBehaviour
{
    public string sceneName ="Game";

    public void ClickStart()
    {
        Debug.Log("로딩");
        SceneManager.LoadScene(sceneName);
    }
    public void ClickLoad()
    {
        Debug.Log("로드");
    }
    public void ClickExit()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }
}
