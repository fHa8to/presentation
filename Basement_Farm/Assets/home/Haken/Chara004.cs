using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara004 : MonoBehaviour
{
    public static int CharCount004 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char004;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kabutoevolution.chara1to2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char004.SetActive(!false);

        }
        if (kabutoevolution.chara1to2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char004.SetActive(false);
        }
    }
}
