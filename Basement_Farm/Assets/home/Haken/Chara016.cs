using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara016 : MonoBehaviour
{
    public static int CharCount016 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char016;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kao.Chara5 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char016.SetActive(!false);

        }
        if (kao.Chara5 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char016.SetActive(false);
        }
    }
}
