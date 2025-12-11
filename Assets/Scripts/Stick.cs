using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Stick : MonoBehaviour
{
    public string lvl;
    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Ball")
        {
            Application.LoadLevel(this.lvl);
        }
    }

    public Stick()
    {
        this.lvl = "MainMenu";
    }

}