using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char002 : MonoBehaviour
{
    public static int CharCount002 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char002;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara2Selection.Chara2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char002.SetActive(!false);

        }
        if (chara2Selection.Chara2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char002.SetActive(false);
        }
    }
}
