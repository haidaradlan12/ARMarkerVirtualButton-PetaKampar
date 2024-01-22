using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour
{
    string vbName;
    public GameObject PinCandi, Candi1, candi2,VideoBatu, PinBatu, VideoPantai,PinPantai, VideoPangan, PinPangan, VideoKerajin, PinKerajin;
    public GameObject vb1, vb2, vb3, vb4, vb5;
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
        PinCandi.SetActive(true);
        PinBatu.SetActive(true);
        PinPantai.SetActive(true);
        PinPangan.SetActive(true);
        PinKerajin.SetActive(true);
        Candi1.SetActive(false);
        candi2.SetActive(false);
        VideoBatu.SetActive(false);
        VideoPantai.SetActive(false);
        VideoPangan.SetActive(false);
        VideoKerajin.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour go)
    {
        vbName = go.VirtualButtonName;
        if (vbName == "Candi")
            Candi();
        else if (vbName == "Batu")
            Batu();
        else if (vbName == "Pantai")
            Pantai();
        else if (vbName == "Pakanan")
            Pakanan();
        else if (vbName == "Kerajinan")
            Kerajinan();
    }

    public void OnButtonReleased(VirtualButtonBehaviour go)
    {
        //Pin.SetActive(true);
        //Candibesar.SetActive(false);
        //Candikecil.SetActive(false);
    }

    void Candi()
    {
        PinCandi.SetActive(false);
        PinBatu.SetActive(false);
        PinPantai.SetActive(false);
        PinPangan.SetActive(false);
        PinKerajin.SetActive(false);
        Candi1.SetActive(true);
        candi2.SetActive(true);
        VideoBatu.SetActive(false);
        VideoPantai.SetActive(false);
        VideoPangan.SetActive(false);
        VideoKerajin.SetActive(false);
        vb1.SetActive(true);
        vb2.SetActive(false);
        vb3.SetActive(false);
        vb4.SetActive(false);
        vb5.SetActive(false);
    }

    void Batu()
    {
        PinCandi.SetActive(true);
        PinBatu.SetActive(false);
        PinPantai.SetActive(true);
        PinPangan.SetActive(true);
        PinKerajin.SetActive(true);
        Candi1.SetActive(false);
        candi2.SetActive(false);
        VideoBatu.SetActive(true);
        VideoPantai.SetActive(false);
        VideoPangan.SetActive(false);
        VideoKerajin.SetActive(false);
        vb1.SetActive(false);
        vb2.SetActive(true);
        vb3.SetActive(false);
        vb4.SetActive(false);
        vb5.SetActive(false);
    }

    void Pantai()
    {
        PinCandi.SetActive(true);
        PinBatu.SetActive(true);
        PinPantai.SetActive(false);
        PinPangan.SetActive(true);
        PinKerajin.SetActive(true);
        Candi1.SetActive(false);
        candi2.SetActive(false);
        VideoBatu.SetActive(false);
        VideoPantai.SetActive(true);
        VideoPangan.SetActive(false);
        VideoKerajin.SetActive(false);
        vb1.SetActive(false);
        vb2.SetActive(false);
        vb3.SetActive(true);
        vb4.SetActive(false);
        vb5.SetActive(false);
    }

    void Pakanan()
    {
        PinCandi.SetActive(true);
        PinBatu.SetActive(true);
        PinPantai.SetActive(true);
        PinPangan.SetActive(false);
        PinKerajin.SetActive(true);
        Candi1.SetActive(false);
        candi2.SetActive(false);
        VideoBatu.SetActive(false);
        VideoPantai.SetActive(false);
        VideoPangan.SetActive(true);
        VideoKerajin.SetActive(false);
        vb1.SetActive(false);
        vb2.SetActive(false);
        vb3.SetActive(false);
        vb4.SetActive(true);
        vb5.SetActive(false);
    }

    void Kerajinan()
    {
        PinCandi.SetActive(true);
        PinBatu.SetActive(true);
        PinPantai.SetActive(true);
        PinPangan.SetActive(true);
        PinKerajin.SetActive(false);
        Candi1.SetActive(false);
        candi2.SetActive(false);
        VideoBatu.SetActive(false);
        VideoPantai.SetActive(false);
        VideoPangan.SetActive(false);
        VideoKerajin.SetActive(true);
        vb1.SetActive(false);
        vb2.SetActive(false);
        vb3.SetActive(false);
        vb4.SetActive(false);
        vb5.SetActive(true);
    }
}