using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara030 : MonoBehaviour
{
    public static int CharCount030 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char030;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Tukievolution.ajin >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char030.SetActive(!false);

        }
        if (Tukievolution.ajin == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char030.SetActive(false);
        }
    }
}
