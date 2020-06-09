using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor : MonoBehaviour
{
    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            Cursor.visible = true;
        }
        else
        {
            if (Time.timeScale == 1f)
            {
                Cursor.visible = false;
            }
        }
    }
}
