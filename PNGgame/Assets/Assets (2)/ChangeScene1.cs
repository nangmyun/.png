using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        SceneManager.LoadScene("game");
    }
}