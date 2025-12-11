using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class CoinPickup : MonoBehaviour
{
    public Transform coinEffect;
    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Ball")
        {
            GameMaster.currentScore = GameMaster.currentScore - 1;
            Transform effect = UnityEngine.Object.Instantiate(this.coinEffect, this.transform.position, this.transform.rotation);
            UnityEngine.Object.Destroy(effect.gameObject, 3);
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }

}