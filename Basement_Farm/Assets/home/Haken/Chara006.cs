using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara006 : MonoBehaviour
{
    public static int CharCount006 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char006;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hanaevolution.hana2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char006.SetActive(!false);

        }
        if (Hanaevolution.hana2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char006.SetActive(false);
        }
    }
}
