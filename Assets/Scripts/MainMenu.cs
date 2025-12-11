using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class MainMenu : MonoBehaviour
{
    public static float vol;
    public AudioSource music;
    public UnityEngine.UI.Slider mySlider;
    private const string VolumePrefKey = "vol2";
    private const string MusicSliderName = "Music Slider";
    private bool resettingAudio;
    public virtual void Start()
    {
        if (!this.music)
        {
            this.music = this.GetComponent<AudioSource>();
        }

        if (!this.mySlider)
        {
            GameObject sliderObj = GameObject.Find(MusicSliderName);
            if (sliderObj)
            {
                this.mySlider = sliderObj.GetComponent<UnityEngine.UI.Slider>();
            }
        }

        float savedVolume = PlayerPrefs.HasKey(VolumePrefKey) ? PlayerPrefs.GetFloat(VolumePrefKey) : MainMenu.vol;
        ApplyVolume(savedVolume, false);

        if (!this.music)
        {
            Debug.LogError("[MainMenu] No AudioSource found on this GameObject; menu music cannot play.");
        }
        else if (!this.music.clip)
        {
            Debug.LogWarning("[MainMenu] AudioSource is assigned but has no clip; assign a menu music clip.");
        }
        else
        {
            Debug.Log("[MainMenu] Music initialized with volume " + this.music.volume + ", clip '" + this.music.clip.name + "'");
        }

        if (!this.mySlider)
        {
            Debug.LogWarning("[MainMenu] Could not find slider named '" + MusicSliderName + "'. Volume UI will not sync.");
        }

        StartCoroutine(VerifyPlayback());
    }

    private void OnEnable()
    {
        AudioSettings.OnAudioConfigurationChanged += HandleAudioConfigChanged;
    }

    private void OnDisable()
    {
        AudioSettings.OnAudioConfigurationChanged -= HandleAudioConfigChanged;
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
        ApplyVolume(vol, true);
    }

    private void ApplyVolume(float volume, bool persist)
    {
        MainMenu.vol = volume;

        if (this.music)
        {
            this.music.mute = false;
            this.music.enabled = true;
            this.music.loop = true;
            this.music.ignoreListenerVolume = false;
            this.music.ignoreListenerPause = false;
            this.music.volume = volume;
            AudioListener.volume = 1f;
            AudioListener.pause = false;
            if (!this.music.isPlaying)
            {
                this.music.Play();
            }
        }

        if (this.mySlider)
        {
            this.mySlider.value = volume;
        }

        if (persist)
        {
            PlayerPrefs.SetFloat(VolumePrefKey, volume);
            PlayerPrefs.Save();
        }
    }

    private void HandleAudioConfigChanged(bool deviceWasChanged)
    {
        if (deviceWasChanged && !this.resettingAudio)
        {
            StartCoroutine(RestoreAudioAfterDeviceChange());
        }
    }

    private IEnumerator RestoreAudioAfterDeviceChange()
    {
        this.resettingAudio = true;
        Debug.LogWarning("[MainMenu] Audio device changed; attempting to reset audio output.");

        // small delay to let Unity attempt its own reset first
        yield return new WaitForSeconds(0.2f);

        AudioConfiguration cfg = AudioSettings.GetConfiguration();
        bool resetOk = AudioSettings.Reset(cfg);

        Debug.Log("[MainMenu] AudioSettings.Reset result: " + resetOk + ", dspRate:" + cfg.sampleRate + ", speakerMode:" + cfg.speakerMode);

        // ensure listener is active
        AudioListener.pause = false;
        AudioListener.volume = 1f;

        // re-apply volume and restart music
        ApplyVolume(MainMenu.vol, false);

        this.resettingAudio = false;
    }

    private IEnumerator VerifyPlayback()
    {
        // wait for one frame so play calls can kick in
        yield return null;
        // small extra delay to allow audio system to start
        yield return new WaitForSeconds(0.1f);

        if (!this.music)
        {
            yield break;
        }

        string clipName = this.music.clip ? this.music.clip.name : "<none>";
        string mixer = (this.music.outputAudioMixerGroup && this.music.outputAudioMixerGroup.audioMixer) ? this.music.outputAudioMixerGroup.audioMixer.name : "<none>";

        Debug.Log("[MainMenu] VerifyPlayback -> " +
                  "clip:" + clipName +
                  ", isPlaying:" + this.music.isPlaying +
                  ", time:" + this.music.time.ToString("F2") +
                  ", vol:" + this.music.volume.ToString("F2") +
                  ", mute:" + this.music.mute +
                  ", enabled:" + this.music.enabled +
                  ", spatialBlend:" + this.music.spatialBlend.ToString("F2") +
                  ", outputMixer:" + mixer +
                  ", listenerPaused:" + AudioListener.pause +
                  ", listenerVol:" + AudioListener.volume.ToString("F2") +
                  ", dspRate:" + AudioSettings.outputSampleRate +
                  ", driver:" + AudioSettings.driverCapabilities);

        // Fallback: force a one-shot in case Play() was ignored
        if (!this.music.isPlaying && this.music.clip)
        {
            this.music.PlayOneShot(this.music.clip, this.music.volume);
            Debug.Log("[MainMenu] Fallback PlayOneShot fired");
        }
    }

    static MainMenu()
    {
        MainMenu.vol = 0.75f;
    }

}