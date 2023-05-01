using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField] AudioSource music;
    private Sprite soundOn;
    public Sprite soundOff;
    public Button button;
    private bool isOn = true;

    void Start()
    {
        soundOn = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOff;
            isOn = false;
            music.Stop();
        }
        else
        {
            button.image.sprite = soundOn;
            isOn = true;
            music.Play();
        }
    }
}
