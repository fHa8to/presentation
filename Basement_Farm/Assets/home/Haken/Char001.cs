using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char001 : MonoBehaviour
{
    public static int CharCount001 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char001;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara1Selection.Chara1 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char001.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char001.SetActive(false);
        }
    }
}
