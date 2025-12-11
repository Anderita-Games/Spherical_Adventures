using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class CoinPickup : MonoBehaviour
{
    public Transform coinEffect;
    public AudioClip coinSound;
    [Range(0f, 1f)]
    public float coinVolume = 1f;
    private const string CoinSoundWarning = "[CoinPickup] No coinSound assigned; assign a clip on the prefab.";

    private void Awake()
    {
        if (!this.coinSound)
        {
            Debug.LogWarning(CoinSoundWarning, this);
        }
    }
    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Ball")
        {
            GameMaster.currentScore = GameMaster.currentScore - 1;
            Transform effect = UnityEngine.Object.Instantiate(this.coinEffect, this.transform.position, this.transform.rotation);
            UnityEngine.Object.Destroy(effect.gameObject, 3);

            PlayCoinSound();

            UnityEngine.Object.Destroy(this.gameObject);
        }
    }

    private void PlayCoinSound()
    {
        if (!this.coinSound)
        {
            Debug.LogWarning(CoinSoundWarning, this);
            return;
        }

        GameObject go = new GameObject("CoinPickupOneShot");
        AudioSource src = go.AddComponent<AudioSource>();
        src.clip = this.coinSound;
        src.volume = this.coinVolume;
        src.spatialBlend = 0f; // 2D so it’s always audible
        src.dopplerLevel = 0f;
        src.rolloffMode = AudioRolloffMode.Linear;
        src.priority = 64;
        src.Play();
        Debug.Log("[CoinPickup] Played coin sound '" + this.coinSound.name + "' at volume " + this.coinVolume, this);
        UnityEngine.Object.Destroy(go, this.coinSound.length);
    }

}