using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeScene : MonoBehaviour
{
    //�z�[����ʂ�
    public void OnClickHomeSceneButton()
    {
        SceneManager.LoadScene("homeScene");
    }
}
