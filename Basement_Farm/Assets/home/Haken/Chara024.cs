using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara024 : MonoBehaviour
{
    public static int CharCount024 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char024;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (musiba.Chara6 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char024.SetActive(!false);

        }
        if (musiba.Chara6 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char024.SetActive(false);
        }
    }
}
