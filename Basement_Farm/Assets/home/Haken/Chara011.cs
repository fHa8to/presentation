using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara011 : MonoBehaviour
{
    public static int CharCount011 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char011;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KusaEvolution.kusa2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char011.SetActive(!false);

        }
        if (KusaEvolution.kusa2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char011.SetActive(false);
        }
    }
}
