//using System; //This is not being Used
using System.Collections.Generic;
//using System.Reflection; //This is not being Used
using UnityEngine;
using UnityEngine.UI;


public class TestScript : MonoBehaviour
{
    [SerializeField]
    private Dictionary<int, GameObject> m_instanceIdToObject;

    private int m_playerHitpoints;
    //Create the reference!
    GameObject obj;
    public MyTestClass()
    {
        m_playerHitpoints = 50;
    }

    private void Awake()
    {
        //How about put it in the Awake?
        obj = GameObject.Find("Player");
        //Verify that this can be done without having an variable on the other side...
        //Verified!
        GetComponent<Button>().onClick.AddListener(DecrementHealthOnClick);
    }

    private void Update()
    {
        // TODO: Twiddle bits
    }

    private void DecrementHealthOnClick()
    {
        m_playerHitpoints -= 1;

        //Garbage collection issue Here! Space is being allocated when function is called everytime it is called. Also why isn’t this put in the Start()? Or even the Awake()?
        //GameObject obj = GameObject.Find("Player");
        if (m_playerHitpoints <= 0)
        {
            obj.SendMessage("IsDead", true);
        }
        else
        {
            obj.SendMessage("IsDead", false);
        }
    }

}
