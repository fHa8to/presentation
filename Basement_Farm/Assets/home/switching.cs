using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switching : MonoBehaviour
{
    public Text ButtonText;
    [SerializeField] public GameObject reset;



    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {

        Debug.Log("�����ꂽ");
        reset.SetActive(false);        // �l���{�^����\��

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
