using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hana : MonoBehaviour
{
    [SerializeField] private GameObject c = GameObject.Find("�Q�[���L����3");

    void Update()
    {

        if (chara3Selection.Chara3 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            c.SetActive(!false);

        }
        if (chara3Selection.Chara3 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            c.SetActive(false);
        }


    }
}
