using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController instance;

    public static GameController Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        StaticData.currentScore=Mathf.FloorToInt(GameObject.Find("Canvas").GetComponent<UIController>().Timer);
        SceneManager.LoadScene("GameOverScene");
    }

}
