using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noramlMusiba2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int normal = 0;  //�m�[�}���ϐ���錾

    public void Update()
    {
        if (GetGenerator.item01 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item01 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        normal += 1;   //�m�[�}���ϐ��𑝂₷

        GetGenerator.item01 -= 1;     //�m�[�}���A�C�e�������炷

        Debug.Log("normal��1�g����");
    }
}
