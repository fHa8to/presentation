using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara017 : MonoBehaviour
{
    public static int CharCount017 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char017;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Kaoevolution.kao2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char017.SetActive(!false);

        }
        if (Kaoevolution.kao2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char017.SetActive(false);
        }
    }
}
