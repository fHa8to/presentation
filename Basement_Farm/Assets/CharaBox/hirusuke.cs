using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hirusuke : MonoBehaviour
{
    public static int Chara4 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara4 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Chara4 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
