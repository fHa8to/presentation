using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class upbringingTrans : MonoBehaviour
{
    //育成画面へ移行
    public void OnClickcharaevolutionBotton()
    {
        SceneManager.LoadScene("chara evolution GameScene");
    }
}
