using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara029 : MonoBehaviour
{
    public static int CharCount029 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char029;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TaijiEvolution.tuki >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char029.SetActive(!false);

        }
        if (TaijiEvolution.tuki == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char029.SetActive(false);
        }
    }
}
