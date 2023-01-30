using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatTrigger : MonoBehaviour
{
    public puzzleCombinationManager QCM;
    public string PlatName;
    public int redPillarValue;
    public int bluePillarValue;
    public int greenPillarValue;
    public int yellowPillarValue;
    //[SerializeField] private Text Ans;

    private void Start()
    {
        QCM = GameObject.FindGameObjectWithTag("QCM").GetComponent<puzzleCombinationManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "RedPillar")
        {
            QCM.playerAnswer(redPillarValue);
            PillarFreeze(collision);
            Debug.Log(redPillarValue);
        }
        if (collision.gameObject.tag == "BluePillar")
        {
            QCM.playerAnswer(bluePillarValue);
            PillarFreeze(collision);
            Debug.Log(bluePillarValue);
        }
        if (collision.gameObject.tag == "GreenPillar")
        {
            QCM.playerAnswer(greenPillarValue);
            PillarFreeze(collision);
            Debug.Log(greenPillarValue);
        }
        if (collision.gameObject.tag == "YellowPillar")
        {
            QCM.playerAnswer(yellowPillarValue);
            PillarFreeze(collision);
            Debug.Log(yellowPillarValue);
        }


    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "RedPillar")
    //    {
    //        QCM.playerAnswer(0);
    //        //Ans.text += number.ToString();
    //        Debug.Log(0);
    //    }
    //    if (collision.gameObject.tag == "BluePillar")
    //    {
    //        QCM.playerAnswer(0);
    //        //Ans.text += number.ToString();
    //        Debug.Log(0);
    //    }
    //    if (collision.gameObject.tag == "GreenPillar")
    //    {
    //        QCM.playerAnswer(0);
    //        //Ans.text += number.ToString();
    //        Debug.Log(0);
    //    }
    //    if (collision.gameObject.tag == "YellowPillar")
    //    {
    //        QCM.playerAnswer(0);
    //        //Ans.text += number.ToString();
    //        Debug.Log(0);
    //    }
    //}

    public void PillarFreeze(Collider2D collider)
    {
        collider.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        
    }
}
