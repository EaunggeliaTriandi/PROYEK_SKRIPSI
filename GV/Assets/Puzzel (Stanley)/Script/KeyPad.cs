using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    private string Answer = "123456";
    private string codesequence;
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }
    public void Enter()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "NAH GITU LET BENER";
        }
        else
        {
            Ans.text = "ASU KRES NGULANG LAGI BANGSAT";
        }
    }
    public void ResetDisplay()
    {
        Ans.text = "";
    }
}
