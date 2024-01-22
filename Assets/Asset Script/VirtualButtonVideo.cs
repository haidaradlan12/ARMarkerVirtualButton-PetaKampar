using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonVideo : MonoBehaviour
{
    public GameObject Pin, Videonya;
    VirtualButtonBehaviour[] awa;
    // Start is called before the first frame update
    void Start()
    {
        awa = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < awa.Length; ++i)
        {
            awa[i].RegisterOnButtonPressed(OnButtonPressed);
            awa[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        Pin.SetActive(true);
        Videonya.SetActive(false);

    }

    public void OnButtonPressed(VirtualButtonBehaviour go
        )
    {
        Pin.SetActive(false);
        Videonya.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour go
        )
    {
        //Pin.SetActive(true);
        //Candibesar.SetActive(false);
        //Candikecil.SetActive(false);
    }

}