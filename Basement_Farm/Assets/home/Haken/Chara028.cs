using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara028 : MonoBehaviour
{
    public static int CharCount028 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char028;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TaijiEvolution.sito >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char028.SetActive(!false);

        }
        if (TaijiEvolution.sito == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char028.SetActive(false);
        }
    }
}
