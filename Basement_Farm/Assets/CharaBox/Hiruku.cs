using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiruku : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hirusukeevolution.hiruku >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Hirusukeevolution.hiruku == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
