using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// �V�[���؂芷���Ɏg�p���郉�C�u����


public class charaBox : MonoBehaviour
{
    public void OnClickCharaBoxButton()
    {
        SceneManager.LoadScene("CharaBox");
    }
}
