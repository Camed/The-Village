using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    private static bool isVisible = false;

    private void Show(bool b)
    {

    }

    public void ShowSettings()
    {
        Show(isVisible);
        isVisible = !isVisible;
    }
}
