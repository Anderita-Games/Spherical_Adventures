using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class LightControl : MonoBehaviour
{
    public Transform target;
    public virtual void Update()
    {
        this.transform.position = this.target.position + new Vector3(0, 0, -2);
        this.transform.LookAt(this.target);
    }

}