using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara019 : MonoBehaviour
{
    public static int CharCount019 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char019;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetGenerator.Chara9 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char019.SetActive(!false);

        }
        if (GetGenerator.Chara9 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char019.SetActive(false);
        }
    }
}
