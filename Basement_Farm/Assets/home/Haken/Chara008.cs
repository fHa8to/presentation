using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara008 : MonoBehaviour
{
    public static int CharCount008 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char008;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (YadokariEvolution.chara1to3to1 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char008.SetActive(!false);

        }
        if (YadokariEvolution.chara1to3to1 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char008.SetActive(false);
        }
    }
}
