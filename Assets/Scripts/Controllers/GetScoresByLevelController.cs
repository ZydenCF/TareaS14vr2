using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GetScoresByLevelController : MonoBehaviour
{
    public void SendRequest(Action<GameOverDataModel> OnCallback)
    {
        StartCoroutine(GetScores( OnCallback));
    }

    IEnumerator GetScores(Action<GameOverDataModel> OnCallback)
    {
        WWWForm form = new WWWForm();
#if UNITY_EDITOR
        if (StaticData.user_id == -1)
        {
            StaticData.user_id = 1;
        }
        if(StaticData.level_id== -1)
        {
            StaticData.level_id = 1;
        }

#endif
        form.AddField("user_id", StaticData.user_id);
        form.AddField("level_id", StaticData.level_id);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/progra241/e2/get_scores_by_level.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError ||
                www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Error");
            }
            else
            {

                OnCallback(JsonUtility.FromJson<GameOverDataModel>(www.downloadHandler.text));
            }
        }
    }
}
