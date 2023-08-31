
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class kabuto : MonoBehaviour
{
  

    [SerializeField] private GameObject a;

    public static int ka = 0;

   
    public void Update()
    {
       
        if (chara1Selection.Chara1 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            a.SetActive(!false);

        }
        if (chara1Selection.Chara1 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            a.SetActive(false);
        }

       
    }
}
