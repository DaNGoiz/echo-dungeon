using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnP2Add10 : MonoBehaviour
{
    Button btnP2;
    public PlayerState state;
    // Start is called before the first frame update
    void Start()
    {
        btnP2 = GetComponent<Button>();
        //btnP2.onClick.AddListener(BtnClkP2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BtnClkP2()
    {
        state.tolerateBar += 10;
        Debug.Log("P2来点笑话10");
    }
}
