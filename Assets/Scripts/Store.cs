using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Store : MonoBehaviour
{
    //ALL THE FREAKING BALLS
    public GameObject ball;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject ball10;
    public GameObject ball11;
    public GameObject ball12;
    public GameObject ball13;
    public GameObject ball14;
    public GameObject ball15;
    public GameObject ball16;
    public GameObject ball17;
    public GameObject ball18;
    public GameObject ball19;
    public GameObject ball20;
    //Teleport locations
    public GameObject target;
    public GameObject target2;
    public static int BallN;
    public int switch2;
    public virtual void start()
    {
        Store.BallN = PlayerPrefs.GetInt("Ball");
    }

    public virtual void update()
    {
        PlayerPrefs.SetInt("Ball", Store.BallN);
    }

    public virtual void right()
    {
        if (this.switch2 == 1)
        {
            Store.BallN = Store.BallN + 1;
            this.switch2 = 0;
        }
        if (PlayerPrefs.GetInt("Ball") <= 1)
        {
            this.ball.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
        }
        if (Store.BallN == 0)
        {
            Store.BallN = 1;
            this.ball.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
            this.ball2.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
        }
        else
        {
            if (Store.BallN == 1)
            {
                Store.BallN = 2;
                this.ball2.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                this.ball3.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
            }
            else
            {
                if (Store.BallN == 2)
                {
                    Store.BallN = 3;
                    this.ball3.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                    this.ball4.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                }
                else
                {
                    if (Store.BallN == 3)
                    {
                        Store.BallN = 4;
                        this.ball4.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                        this.ball5.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                    }
                    else
                    {
                        if (Store.BallN == 4)
                        {
                            Store.BallN = 5;
                            this.ball5.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                            this.ball6.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                        }
                        else
                        {
                            if (Store.BallN == 5)
                            {
                                Store.BallN = 6;
                                this.ball6.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                this.ball7.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                            }
                            else
                            {
                                if (Store.BallN == 6)
                                {
                                    Store.BallN = 7;
                                    this.ball7.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                    this.ball8.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                }
                                else
                                {
                                    if (Store.BallN == 7)
                                    {
                                        Store.BallN = 8;
                                        this.ball8.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                        this.ball9.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                    }
                                    else
                                    {
                                        if (Store.BallN == 8)
                                        {
                                            Store.BallN = 9;
                                            this.ball9.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                            this.ball10.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                        }
                                        else
                                        {
                                            if (Store.BallN == 9)
                                            {
                                                Store.BallN = 10;
                                                this.ball10.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                this.ball11.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                            }
                                            else
                                            {
                                                if (Store.BallN == 10)
                                                {
                                                    Store.BallN = 11;
                                                    this.ball11.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                    this.ball12.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                }
                                                else
                                                {
                                                    if (Store.BallN == 11)
                                                    {
                                                        Store.BallN = 12;
                                                        this.ball12.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                        this.ball13.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                    }
                                                    else
                                                    {
                                                        if (Store.BallN == 12)
                                                        {
                                                            Store.BallN = 13;
                                                            this.ball13.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                            this.ball14.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                        }
                                                        else
                                                        {
                                                            if (Store.BallN == 13)
                                                            {
                                                                Store.BallN = 14;
                                                                this.ball14.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                this.ball15.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                            }
                                                            else
                                                            {
                                                                if (Store.BallN == 14)
                                                                {
                                                                    Store.BallN = 15;
                                                                    this.ball15.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                    this.ball16.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                }
                                                                else
                                                                {
                                                                    if (Store.BallN == 15)
                                                                    {
                                                                        Store.BallN = 16;
                                                                        this.ball16.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                        this.ball17.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (Store.BallN == 16)
                                                                        {
                                                                            Store.BallN = 17;
                                                                            this.ball17.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                            this.ball18.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                        }
                                                                        else
                                                                        {
                                                                            if (Store.BallN == 17)
                                                                            {
                                                                                Store.BallN = 18;
                                                                                this.ball18.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                this.ball19.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                            }
                                                                            else
                                                                            {
                                                                                if (Store.BallN == 18)
                                                                                {
                                                                                    Store.BallN = 19;
                                                                                    this.ball19.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                    this.ball20.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (Store.BallN == 19)
                                                                                    {
                                                                                        Store.BallN = 0;
                                                                                        this.ball20.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                        this.ball.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public virtual void left()
    {
        if (this.switch2 == 0)
        {
            this.switch2 = 1;
            if (Store.BallN == 0)
            {
                Store.BallN = 19;
            }
            else
            {
                Store.BallN = Store.BallN - 1;
            }
        }
        if (PlayerPrefs.GetInt("Ball") <= 1)
        {
            this.ball.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
        }
        if (Store.BallN == 19)
        {
            Store.BallN = 18;
            this.ball.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
            this.ball20.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
        }
        else
        {
            if (Store.BallN == 18)
            {
                Store.BallN = 17;
                this.ball20.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                this.ball19.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
            }
            else
            {
                if (Store.BallN == 17)
                {
                    Store.BallN = 16;
                    this.ball19.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                    this.ball18.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                }
                else
                {
                    if (Store.BallN == 16)
                    {
                        Store.BallN = 15;
                        this.ball18.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                        this.ball17.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                    }
                    else
                    {
                        if (Store.BallN == 15)
                        {
                            Store.BallN = 14;
                            this.ball17.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                            this.ball16.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                        }
                        else
                        {
                            if (Store.BallN == 14)
                            {
                                Store.BallN = 13;
                                this.ball16.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                this.ball15.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                            }
                            else
                            {
                                if (Store.BallN == 13)
                                {
                                    Store.BallN = 12;
                                    this.ball15.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                    this.ball14.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                }
                                else
                                {
                                    if (Store.BallN == 12)
                                    {
                                        Store.BallN = 11;
                                        this.ball14.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                        this.ball13.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                    }
                                    else
                                    {
                                        if (Store.BallN == 11)
                                        {
                                            Store.BallN = 10;
                                            this.ball13.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                            this.ball12.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                        }
                                        else
                                        {
                                            if (Store.BallN == 10)
                                            {
                                                Store.BallN = 9;
                                                this.ball12.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                this.ball11.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                            }
                                            else
                                            {
                                                if (Store.BallN == 9)
                                                {
                                                    Store.BallN = 8;
                                                    this.ball11.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                    this.ball10.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                }
                                                else
                                                {
                                                    if (Store.BallN == 8)
                                                    {
                                                        Store.BallN = 7;
                                                        this.ball10.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                        this.ball9.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                    }
                                                    else
                                                    {
                                                        if (Store.BallN == 7)
                                                        {
                                                            Store.BallN = 6;
                                                            this.ball9.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                            this.ball8.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                        }
                                                        else
                                                        {
                                                            if (Store.BallN == 6)
                                                            {
                                                                Store.BallN = 5;
                                                                this.ball8.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                this.ball7.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                            }
                                                            else
                                                            {
                                                                if (Store.BallN == 5)
                                                                {
                                                                    Store.BallN = 4;
                                                                    this.ball7.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                    this.ball6.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                }
                                                                else
                                                                {
                                                                    if (Store.BallN == 4)
                                                                    {
                                                                        Store.BallN = 3;
                                                                        this.ball6.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                        this.ball5.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (Store.BallN == 3)
                                                                        {
                                                                            Store.BallN = 2;
                                                                            this.ball5.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                            this.ball4.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                        }
                                                                        else
                                                                        {
                                                                            if (Store.BallN == 2)
                                                                            {
                                                                                Store.BallN = 1;
                                                                                this.ball4.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                this.ball3.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                            }
                                                                            else
                                                                            {
                                                                                if (Store.BallN == 1)
                                                                                {
                                                                                    Store.BallN = 0;
                                                                                    this.ball3.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                    this.ball2.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (Store.BallN == 0)
                                                                                    {
                                                                                        Store.BallN = 19;
                                                                                        this.ball2.transform.position = new Vector3(this.target2.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                        this.ball.transform.position = new Vector3(this.target.transform.position.x, this.target.transform.position.y, this.target.transform.rotation.x);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}