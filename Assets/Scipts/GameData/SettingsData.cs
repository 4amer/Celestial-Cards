using System.Collections.Generic;
using Unity.VisualScripting;

public class SettingsData
{
    private static SettingsData settingsData;


    // Input
    public List<string, string> avalebleInputSymbals = { "A" };


    private SettingsData() { }

    public static SettingsData Instance 
    { 
        get
        {
            if(settingsData == null) settingsData = new SettingsData();
            return settingsData;
        }
    }
}
