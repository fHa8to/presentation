using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuki : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (TaijiEvolution.tuki >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (TaijiEvolution.tuki == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
