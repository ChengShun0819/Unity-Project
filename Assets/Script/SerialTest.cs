using UnityEngine;
using System.IO.Ports;
using System;

public class SerialTest : MonoBehaviour {
    public SerialPort sp = new SerialPort("COM3", 9600);
    void Start () {
        sp.ReadTimeout = 10;
        sp.Open();
    }
    void FixedUpdate() {
        if (sp.IsOpen)
        {
            try
            {
                string value = sp.ReadLine();
                if (value != "")
                {
                    string[] strArray = value.Split(new char[] { ',' });
                    if (strArray[0].Equals("1"))
                    {
                        transform.Translate(0, 0, 0.1f);
                    }
                    if (strArray[1].Equals("1"))
                    {
                        transform.Translate(0, 0, -0.1f);
                    }
                    if (strArray[2].Equals("1"))
                    {
                        transform.Rotate(0, -3, 0);
                    }
                    if (strArray[3].Equals("1"))
                    {
                        transform.Rotate(0, 3, 0);
                    }
                    int value4 = 0;
                    if (Int32.TryParse(strArray[4], out value4))
                    {
                        transform.localScale = new Vector3(value4, value4, value4);
                    }
                }
            }
            catch
            {
                Debug.Log("Error");
            }


            if (Input.GetKeyUp("a"))
            {
                sp.Write("a");
            }
            else if (Input.GetKeyUp("b")) {
                sp.Write("b");
            }
        }
    }
}

