using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class barrel : MonoBehaviour
{
    public GameObject target2;
    public Transform TeleportEffect3;
    public Transform TeleportEffect4;
    public int maxFallDistance2;
    public virtual void Update()
    {
        if (this.transform.position.y <= this.maxFallDistance2)
        {
            this.gameObject.transform.position = new Vector3(this.target2.transform.position.x, this.target2.transform.position.y, this.target2.transform.rotation.x);
            this.TeleportEffect4 = UnityEngine.Object.Instantiate(this.TeleportEffect3, this.transform.position, this.transform.rotation);
            this.transform.Rotate(Vector3.right * Time.deltaTime);
            UnityEngine.Object.Destroy(this.TeleportEffect4.gameObject, 1.1f);
        }
    }

    public barrel()
    {
        this.maxFallDistance2 = -1;
    }

}