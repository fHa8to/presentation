using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class chara2Selection : MonoBehaviour
{

    public static int Chara2 = 0;   //�L�����ϐ���錾����

    //�I�u�W�F�N�g�N���b�N�őI�񂾃L�����ȊO������
    public void OnTouched()
    {
        //�I�΂�Ȃ������L������錾
        GameObject obj1 = GameObject.Find("�L�����P");
        GameObject obj2 = GameObject.Find("��");

        Debug.Log("���߂Ẵ����X�^�[���I");

        //�I�΂�Ȃ������L������j��
        Destroy(obj1);
        Destroy(obj2);

        Chara2 += 1;
    }
}
