using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public static string MapName;

    private static string Easy1 = "false";
    private static string Easy2 = "false";
    private static string Easy3 = "false";
    private static string Easy4 = "false";

    private static string Medium1 = "false";
    private static string Medium2 = "false";
    private static string Medium3 = "false";
    private static string Medium4 = "false";

    private static string Hard1 = "false";
    private static string Hard2 = "false";
    private static string Hard3 = "false";
    private static string Hard4 = "false";

    private static string Insane1 = "false";
    public void Start()
    {
        loadMaps();

        if (MapName == "Easy1")
        {
            Easy1 = "True";
        }
        else if (MapName == "Easy2")
        {
            Easy2 = "True";
        }
        else if (MapName == "Easy3")
        {
            Easy3 = "True";
        }
        else if (MapName == "Easy4")
        {
            Easy4 = "True";
        }
        else if (MapName == "Medium1")
        {
            Medium1 = "True";
        }
        else if (MapName == "Medium2")
        {
            Medium2 = "True";
        }
        else if (MapName == "Medium3")
        {
            Medium3 = "True";
        }
        else if (MapName == "Medium4")
        {
            Medium4 = "True";
        }
        else if (MapName == "Hard1")
        {
            Hard1 = "True";
        }
        else if (MapName == "Hard2")
        {
            Hard2 = "True";
        }
        else if (MapName == "Hard3")
        {
            Hard3 = "True";
        }
        else if (MapName == "Hard4")
        {
            Hard4 = "True";
        }
        else if (MapName == "Insane1")
        {
            Insane1 = "True";
        }

        //print("Easy1 = " + Easy1);
        //print("Easy2 = " + Easy2);
        //print("Easy3 = " + Easy3);
        //print("Easy4 = " + Easy4);

        //print("Medium1 = " + Medium1);
        //print("Medium2 = " + Medium2);
        //print("Medium3 = " + Medium3);
        //print("Medium4 = " + Medium4);

        //print("Hard1 = " + Hard1);
        //print("Hard2 = " + Hard2);
        //print("Hard3 = " + Hard3);
        //print("Hard4 = " + Hard4);

        //print("Insane = " + Insane);

        SaveMaps();
    }

    public void loadMaps()
    {
        //PlayerPrefs.DeleteAll();

        Easy1 = PlayerPrefs.GetString("Easy1");
        Easy2 = PlayerPrefs.GetString("Easy2");
        Easy3 = PlayerPrefs.GetString("Easy3");
        Easy4 = PlayerPrefs.GetString("Easy4");

        Medium1 = PlayerPrefs.GetString("Medium1");
        Medium2 = PlayerPrefs.GetString("Medium2");
        Medium3 = PlayerPrefs.GetString("Medium3");
        Medium4 = PlayerPrefs.GetString("Medium4");

        Hard1 = PlayerPrefs.GetString("Hard1");
        Hard2 = PlayerPrefs.GetString("Hard2");
        Hard3 = PlayerPrefs.GetString("Hard3");
        Hard4 = PlayerPrefs.GetString("Hard4");

        Insane1 = PlayerPrefs.GetString("Insane1");
    }

    public void SaveMaps()
    {
        PlayerPrefs.SetString("Easy1", Easy1);
        PlayerPrefs.SetString("Easy2", Easy2);
        PlayerPrefs.SetString("Easy3", Easy3);
        PlayerPrefs.SetString("Easy4", Easy4);

        PlayerPrefs.SetString("Medium1", Medium1);
        PlayerPrefs.SetString("Medium2", Medium2);
        PlayerPrefs.SetString("Medium3", Medium3);
        PlayerPrefs.SetString("Medium4", Medium4);

        PlayerPrefs.SetString("Hard1", Hard1);
        PlayerPrefs.SetString("Hard2", Hard2);
        PlayerPrefs.SetString("Hard3", Hard3);
        PlayerPrefs.SetString("Hard4", Hard4);

        PlayerPrefs.SetString("Insane1", Insane1);
        PlayerPrefs.Save();
    }
    private void OnApplicationQuit()
    {
        SaveMaps();
        print("Quitting app");
    }

}
