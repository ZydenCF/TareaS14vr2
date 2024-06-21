using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScoresByLevelView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoresText;
    private GetScoresByLevelController controller;

    private void Awake()
    {
        controller = GetComponent<GetScoresByLevelController>();
    }

    private void Start()
    {
        controller.SendRequest(OnResult);
    }

    private void OnResult(GameOverDataModel data)
    {
        scoresText.text = "";
        foreach (GameOverScoreModel score in data.scores)
        {
            scoresText.text += $"Score: {score.value}\n";
        }
    }
}
