using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Disable : MonoBehaviour
{

    public Transform soda;
    public Transform chicken; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pC = chicken.position;
        Vector2 pS = soda.position;


        if (pC.x <= pS.x - 4 || pC.x >= pS.x + 4 || pC.y <= pS.y - 4 || pC.y >= + 4)
        {

            chicken.gameObject.SetActive(true);
        }
        else

        {
            chicken.gameObject.SetActive(false);

        }




        // Position - Position 





    }





}
