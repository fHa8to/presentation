using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara021 : MonoBehaviour
{
    public static int CharCount021 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char021;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bakuteriaevolution.bagu >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char021.SetActive(!false);

        }
        if (Bakuteriaevolution.bagu == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char021.SetActive(false);
        }
    }
}
