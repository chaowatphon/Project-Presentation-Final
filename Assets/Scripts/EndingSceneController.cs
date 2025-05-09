using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneController : MonoBehaviour
{
    public float delayToCredit = 5f; // รอ 5 วิแล้วไป CreditScene

    void Start()
    {
        Invoke("GoToCreditScene", delayToCredit);
    }

    void GoToCreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
