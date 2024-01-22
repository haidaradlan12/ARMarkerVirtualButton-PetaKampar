using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuUtama1, MenuUtama2, MenuUtama3, MenuButton, MenuInformasi, MenuPetunjuk, MenuOrang;
    // Start is called before the first frame update
    void Start()
    {
        MenuUtama1.DOAnchorPos(new Vector2(0,0), 1.0f);
        MenuUtama2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtama3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuOrang.DOAnchorPos(new Vector2(2500, 0), 1.0f);

    }
    public void MenuUtamabutton()
    {
        MenuUtama1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtama2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtama3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuOrang.DOAnchorPos(new Vector2(2500, 0), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuUtama1.DOAnchorPos(new Vector2(0, -1200), 1.0f);
        MenuUtama2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuUtama3.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuOrang.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuUtama1.DOAnchorPos(new Vector2(0, -1200), 1.0f);
        MenuUtama2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuUtama3.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrang.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

}
