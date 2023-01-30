using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarManager : MonoBehaviour
{
    public FaddingUI fadding;
    private puzzleCombinationManager QCM;
    public Transform[] PillarBase;
    public GameObject[] Pillar;

    private void Start()
    {
        QCM = GameObject.FindGameObjectWithTag("QCM").GetComponent<puzzleCombinationManager>();
    }
    public IEnumerator PillarReset()
    {
        yield return new WaitForSeconds(5);
        callReset();
    }

    public void callReset()
    {
        fadding.callFadding();
        RP(0, 0);
        RP(1, 1);
        RP(2, 2);
        RP(3, 3);
        for (int i = 0; i < Pillar.Length; i++)
        {
            Pillar[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            QCM.answer = "";
        }

    }
    public void RP(int pillarNumber, int baseNumber)
    {
        Pillar[pillarNumber].transform.position = PillarBase[baseNumber].position;
    }
}
