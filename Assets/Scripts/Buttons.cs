using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Buttons : MonoBehaviour
{
    public bool paused;
    public GameObject Tpaused;
    public float speedr;
    public float speedl;
    private bool isFalling;
    public Transform TeleportEffect;
    public Transform TeleportEffect2;
    public Transform target;
    public int jumpHeight;
    public AudioClip Jump;
    public virtual void QuitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public virtual void Start()
    {
        this.Tpaused.SetActive(false);
    }

    public virtual void leftarrow()
    {

        {
            float _5 = this.speedl;
            Vector3 _6 = this.GetComponent<Rigidbody>().velocity;
            _6.x = _5;
            this.GetComponent<Rigidbody>().velocity = _6;
        }
        Debug.Log("Going left...");
    }

    public virtual void rightarrow()
    {

        {
            float _7 = this.speedr;
            Vector3 _8 = this.GetComponent<Rigidbody>().velocity;
            _8.x = _7;
            this.GetComponent<Rigidbody>().velocity = _8;
        }
        Debug.Log("Going right...");
    }

    public virtual void uparrow()
    {
        if (this.isFalling == false)
        {

            {
                int _9 = this.jumpHeight;
                Vector3 _10 = this.GetComponent<Rigidbody>().velocity;
                _10.y = _9;
                this.GetComponent<Rigidbody>().velocity = _10;
            }
            this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
            this.isFalling = true;
            Debug.Log("Jumping...");
        }
        else
        {
            if (this.isFalling == false)
            {

                {
                    int _11 = this.jumpHeight;
                    Vector3 _12 = this.GetComponent<Rigidbody>().velocity;
                    _12.y = _11;
                    this.GetComponent<Rigidbody>().velocity = _12;
                }
                this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
                this.isFalling = true;
            }
        }
    }

    public virtual void OnCollisionStay()
    {
        this.isFalling = false;
    }

    public virtual void teleport()
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

    public virtual void pause()
    {
        if (this.paused == false)
        {
            Debug.Log("Pausing...");
            this.paused = true;
            Time.timeScale = 0;
            this.Tpaused.SetActive(true);
        }
        else
        {
            if (this.paused == true)
            {
                Debug.Log("Pausing...");
                this.paused = false;
                Time.timeScale = 1;
                this.Tpaused.SetActive(false);
            }
        }
    }

    public virtual void MainMenu()
    {
        Application.LoadLevel("MainMenu");
        this.paused = false;
        Time.timeScale = 1;
    }

    public virtual void Playgame()
    {
        if (PlayerPrefs.HasKey("savedLevel"))
        {
            // there is a saved level, load that one
            Application.LoadLevel(PlayerPrefs.GetString("savedLevel"));
        }
        else
        {
            // no saved level, load the first one
            Application.LoadLevel("Level1");
        }
    }

    public virtual void LevelS()
    {
        Application.LoadLevel("LevelSelect");
    }

    public virtual void LevelS2()
    {
        Application.LoadLevel("LevelSelect2");
    }

    public virtual void Store()
    {
        Application.LoadLevel("Store");
    }

    public virtual void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

    public virtual void Level1()
    {
        Application.LoadLevel("Level1");
    }

    public virtual void Level2()
    {
        Application.LoadLevel("Level2");
    }

    public virtual void Level3()
    {
        Application.LoadLevel("Level3");
    }

    public virtual void Level4()
    {
        Application.LoadLevel("Level4");
    }

    public virtual void Level5()
    {
        Application.LoadLevel("Level5");
    }

    public virtual void Level6()
    {
        Application.LoadLevel("Level6");
    }

    public virtual void Level7()
    {
        Application.LoadLevel("Level7");
    }

    public virtual void Level8()
    {
        Application.LoadLevel("Level8");
    }

    public virtual void Level9()
    {
        Application.LoadLevel("Level9");
    }

    public virtual void Level10()
    {
        Application.LoadLevel("Level10");
    }

    public virtual void Level11()
    {
        Application.LoadLevel("Level11");
    }

    public virtual void Level12()
    {
        Application.LoadLevel("Level12");
    }

    public Buttons()
    {
        this.speedr = 5f;
        this.speedl = -5f;
        this.jumpHeight = 8;
    }

}