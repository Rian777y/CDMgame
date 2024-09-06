using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animmaq : MonoBehaviour
{
    public Animator maquinaAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            maquinaAnimator.SetInteger("Excavator", 2);
            return;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            maquinaAnimator.SetInteger("Excavator", 1);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maquinaAnimator.SetInteger("Excavator", 1);
        }
        else
        {
            maquinaAnimator.SetInteger("Excavator", 0);
        }
      

    }
}
