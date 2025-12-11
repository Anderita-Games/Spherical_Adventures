using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Teleport : MonoBehaviour
{
    public GameObject target;
    public Transform TeleportEffect;
    public Transform TeleportEffect2;
    public int maxFallDistance;
    public string lvl1;
    public virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (GameMaster.teleports <= 0)
            {
                Debug.Log("No more Teleports Left!");
            }
            else
            {
                GameMaster.teleports = GameMaster.teleports - 1;
                this.gameObject.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                Transform effect = UnityEngine.Object.Instantiate(this.TeleportEffect, this.transform.position, this.transform.rotation);
                this.transform.Rotate(Vector3.right * Time.deltaTime);
                UnityEngine.Object.Destroy(effect.gameObject, 1.1f);
            }
        }
        if (this.transform.position.y <= this.maxFallDistance)
        {
            if (GameMaster.teleports <= 0)
            {
                Application.LoadLevel(this.lvl1);
            }
            else
            {
                GameMaster.teleports = GameMaster.teleports - 1;
                this.gameObject.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                Transform effect2 = UnityEngine.Object.Instantiate(this.TeleportEffect, this.transform.position, this.transform.rotation);
                this.transform.Rotate(Vector3.right * Time.deltaTime);
                UnityEngine.Object.Destroy(effect2.gameObject, 1.1f);
            }
        }
    }

    public virtual void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Barrel")
        {
            GameMaster.teleports = GameMaster.teleports - 1;
            this.gameObject.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
            Transform effect3 = UnityEngine.Object.Instantiate(this.TeleportEffect, this.transform.position, this.transform.rotation);
            this.transform.Rotate(Vector3.right * Time.deltaTime);
            UnityEngine.Object.Destroy(effect3.gameObject, 1.1f);
        }
    }

    public Teleport()
    {
        this.maxFallDistance = -175;
        this.lvl1 = "Level1";
    }

}