using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScrip : MonoBehaviour {

    Animator animator = null;
    // Use this for initialization
    void Start () {
        animator =this.GetComponent<Animator>();
        animator.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")) {
            animator.enabled = false;
            transform.Translate(0, 0, 0.1f);
        }
        // 按住 上鍵 時，物件每個 frame 朝自身 z 軸方向移動 0.1 公尺
        if (Input.GetKey("down")) {
            animator.enabled = false;
            transform.Translate(0, 0, -0.1f);
        }
        // 按住 下鍵 時，物件每個 frame 朝自身 z 軸方向移動 -0.1 公尺
        if (Input.GetKey("left")) {
            animator.enabled = false;
            transform.Rotate(0, -3, 0);
        }
        // 按住 左鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 -3 度
        if (Input.GetKey("right")) {
            animator.enabled = false;
            transform.Rotate(0, 3, 0);
        }
        // 按住 右鍵 時，物件每個 frame 以自身 y 軸為軸心旋轉 3 度


        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            animator.enabled = true;
            this.GetComponent<Animator>().SetInteger("state", 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            animator.enabled = true;
            this.GetComponent<Animator>().SetInteger("state", 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            animator.enabled = true;
            this.GetComponent<Animator>().SetInteger("state", 2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            animator.enabled = true;
            this.GetComponent<Animator>().SetInteger("state", 3);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            var manObj = Instantiate(GameObject.Find("Man"));
            Destroy(manObj.GetComponent<Animator>());
            Destroy(manObj.GetComponent<BaseScrip>());
            manObj.transform.position = this.transform.position + new Vector3(5, 0, 0);
            manObj.transform.Rotate(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var wind_Sound = GameObject.Find("Sound_Wind").GetComponent<AudioSource>();

            if (wind_Sound.isPlaying)
            {
                wind_Sound.Pause();
            }
            else {
                wind_Sound.Play();
            }
        }
    }

}
