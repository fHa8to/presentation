using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneTrans : MonoBehaviour
{
    //�z�[���V�[���ֈڍs
    public void OnClickToHomeSceneBotton()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
