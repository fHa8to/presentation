using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chara3Selection : MonoBehaviour
{
   

    public static int Chara3 = 0;  //�L�����ϐ���錾����

    //�I�u�W�F�N�g�N���b�N�őI�񂾃L�����ȊO������
    public void OnTouched()
    {
        //�I�΂�Ȃ������L������錾
        GameObject obj = GameObject.Find("monster");
        GameObject obj1 = GameObject.Find("�L�����P");

        Debug.Log("���߂Ẵ����X�^�[���I");

        //�I�΂�Ȃ������L������j��
        Destroy(obj);
        Destroy(obj1);

       

        Chara3 += 1;
    }
}
