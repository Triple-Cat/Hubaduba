using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSwap : MonoBehaviour
{
    public int x;
    public void SetSelectedLocale(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }
    public void Language_swap()
    {
            SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[x]);
      
    }
}
