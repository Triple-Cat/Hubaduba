using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSwap : MonoBehaviour
{
    int x = 1;
    public void SetSelectedLocale(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }
    public void Language_swap()
    {
        if (x == 1)
        {
            SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
            x = 0;
        }
        else
        {
            SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[1]);
            x = 1;
        }
    }
}
