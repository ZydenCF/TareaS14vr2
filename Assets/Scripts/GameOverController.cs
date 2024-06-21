using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreText;

    private void Start()
    {
        currentScoreText.text = $"Current score: {StaticData.currentScore}";
    }
}
