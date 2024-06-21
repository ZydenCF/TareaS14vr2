using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float timer;

    public float Timer
    {
        get 
        {
            return timer; 
        } 
    
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = $"Time: {Mathf.FloorToInt(timer)}";
    }

}
