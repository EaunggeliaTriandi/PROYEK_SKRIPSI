using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            GameObject a = pool.singleton.Get("apple");
            if (a != null)
            {
                a.transform.position = this.transform.position+ 
                                      new Vector3(Random.Range(-1,1), 0,0);
                a.SetActive(true);
                
            }
            //get Array to Fixed Position
            GameObject b = pool.singleton.GetList("GuideLetter", 2);
            if (b != null)
            {
                b.transform.position = this.transform.position +
                                    new Vector3(1, 1, 0);
                b.SetActive(true);
            }

        }
    }
}
