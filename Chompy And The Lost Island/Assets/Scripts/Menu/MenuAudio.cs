using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    public void ButtonPress()
    {
        AudioManager.instance.Play("ButtonPress");
    }
}
