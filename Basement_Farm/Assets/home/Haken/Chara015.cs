using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara015 : MonoBehaviour
{
    public static int CharCount015 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char015;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Hirusukeevolution.hirunann >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char015.SetActive(!false);

        }
        if (Hirusukeevolution.hirunann == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char015.SetActive(false);
        }
    }
}
