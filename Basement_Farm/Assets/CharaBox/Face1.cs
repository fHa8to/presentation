using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face1 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Faceevolution.face >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Faceevolution.face == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
