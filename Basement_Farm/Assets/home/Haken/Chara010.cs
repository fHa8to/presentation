using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara010 : MonoBehaviour
{
    public static int CharCount010 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char010;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hana2evolution.hana3 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char010.SetActive(!false);

        }
        if (Hana2evolution.hana3 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char010.SetActive(false);
        }
    }
}
