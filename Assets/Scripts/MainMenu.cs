using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class MainMenu : MonoBehaviour
{
    public static float vol;
    public AudioSource music;
    public UnityEngine.UI.Slider mySlider;
    public virtual void Start()
    {
        this.mySlider = (UnityEngine.UI.Slider) GameObject.Find("Music Slider").GetComponent(typeof(UnityEngine.UI.Slider));
        if (PlayerPrefs.HasKey("vol2"))
        {
            this.music.volume = PlayerPrefs.GetFloat("vol2");
            MainMenu.vol = PlayerPrefs.GetFloat("vol2");
            this.mySlider.value = PlayerPrefs.GetFloat("vol2");
        }
        else
        {
            PlayerPrefs.SetFloat("vol2", MainMenu.vol);
        }
    }

    public virtual void QuitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public virtual void StartGame()
    {
        Application.LoadLevel("level1");
    }

    public virtual void StartT()
    {
        Application.LoadLevel("Tutorial");
    }

    public virtual void SetGameVolume(float vol)
    {
        this.music.volume = vol;
        PlayerPrefs.SetFloat("vol2", vol);
    }

    static MainMenu()
    {
        MainMenu.vol = 0.75f;
    }

}