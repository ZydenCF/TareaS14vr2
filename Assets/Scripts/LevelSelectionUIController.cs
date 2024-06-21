using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelSelectionUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userIdText;
    [SerializeField] private TextMeshProUGUI usernameText;


    // Start is called before the first frame update
    void Start()
    {
        userIdText.text = $"User ID: {StaticData.user_id}";   
        usernameText.text = $"Username: {StaticData.username}";   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
