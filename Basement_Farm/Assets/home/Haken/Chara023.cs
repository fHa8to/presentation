using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara023 : MonoBehaviour
{
    public static int CharCount023 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char023;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kusa.Chara7 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char023.SetActive(!false);

        }
        if (kusa.Chara7 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char023.SetActive(false);
        }
    }
}
