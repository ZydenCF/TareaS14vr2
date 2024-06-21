using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginView : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private Button loginButton;
    [SerializeField] private TextMeshProUGUI messageText;
    private LoginController controller;
    private void Awake()
    {
        loginButton.onClick.AddListener(ClickLogin);
        controller= GetComponent<LoginController>();
    }

    private void ClickLogin()
    {
        controller.SendRequest(usernameInputField.text, OnResult);
    }

    private void OnResult(RegisterModel registerModel)
    {
        if (registerModel != null)
        {
            if (registerModel.data != null)
            {
                messageText.text = $"{registerModel.message}:\n{registerModel.data.user.username}";
                StaticData.user_id = registerModel.data.user.user_id;
                StaticData.username = registerModel.data.user.username;
                SceneManager.LoadScene("LevelSelectionScene");
            }
            else
            {
                messageText.text = $"{registerModel.message}";
            }
        }
        else
        {
            messageText.text = "Error desconocido";
        }
    }
}
