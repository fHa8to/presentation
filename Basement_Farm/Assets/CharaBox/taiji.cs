using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taiji : MonoBehaviour
{
    public static int Chara8 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara8 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Chara8 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
