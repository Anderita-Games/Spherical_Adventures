using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class GameMaster : MonoBehaviour
{
    public static int currentScore;
    public static int specialScore;
    public static int teleports;
    public static int zero;
    public static int TextWidth;
    public static string savedLevel;
    public float sizeX;
    public float sizeY;
    public string lvl;
    public int w;
    public virtual void Start()
    {
        GameMaster.currentScore = 10;
        GameMaster.specialScore = 0;
        GameMaster.teleports = 5;
        Debug.Log(Application.loadedLevelName);
    }

    public virtual void Update()
    {
        if (GameMaster.currentScore <= 0)
        {
            if (Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
                Application.LoadLevel(this.lvl);
                //saving playerPrefs
                PlayerPrefs.SetString("savedLevel", this.lvl);
            }
            else
            {
                if (GameMaster.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
                {
                    PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
                    Application.LoadLevel(this.lvl);
                    //saving playerPrefs
                    PlayerPrefs.SetString("savedLevel", this.lvl);
                }
                else
                {
                    Application.LoadLevel(this.lvl);
                    //saving playerPrefs
                    PlayerPrefs.SetString("savedLevel", this.lvl);
                }
            }
        }
    }

    public virtual void OnGUI()
    {
        GUI.skin.box.fontSize = Screen.width / 80;
        //Boxes
        GUI.Box(new Rect(Screen.width - (Screen.width * 0.12f), 0, Screen.width / 8, Screen.height / 16), "Coins Left: " + GameMaster.currentScore);
        GUI.Box(new Rect(0, 0, Screen.width / 8, Screen.height / 16), ("Special Coins: " + GameMaster.specialScore) + "/3");
        GUI.Box(new Rect((Screen.width / 8) + 10, 0, Screen.width / 8, Screen.height / 16), "Teleports Left: " + GameMaster.teleports);
        GUI.Box(new Rect(((Screen.width / 8) + 20) + (Screen.width / 8), 0, Screen.width / 6, Screen.height / 16), "Current Time: " + Time.timeSinceLevelLoad);
        if (GameMaster.zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
        {
            GUI.Box(new Rect((((Screen.width / 8) + (Screen.width / 8)) + (Screen.width / 6)) + 30, 0, Screen.width / 6, Screen.height / 16), "No best time!!!");
        }
        else
        {
            if (GameMaster.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                GUI.Box(new Rect((((Screen.width / 8) + (Screen.width / 8)) + (Screen.width / 6)) + 30, 0, Screen.width / 6, Screen.height / 16), ("Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) + " seconds");
            }
        }
    }

    public GameMaster()
    {
        this.sizeX = 200;
        this.sizeY = 100;
        this.lvl = "MainMenu";
        this.w = Screen.width / 2;
    }

    static GameMaster()
    {
        GameMaster.currentScore = 10;
        GameMaster.teleports = 5;
        GameMaster.TextWidth = Screen.width / 4;
    }

}