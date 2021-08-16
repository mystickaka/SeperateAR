using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartBtnController : MonoBehaviour
{
    //public GameObject nextBtn;
    public GameObject restartBtn;
    public GameObject recordBtn;
    public GameObject timer;
    public GameObject tip;
    public GameObject okBtn;

    public static int times = 0;//点击次数

    // Start is called before the first frame update
    void Start()
    {
        /*
        //点击下一步
        nextBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            nextBtn.SetActive(false);
            restartBtn.SetActive(false);
            //显示拍摄按钮
            recordBtn.SetActive(true);

            
        });
        */
        //点击重新拍摄
        restartBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Debug.Log("!");
            restartBtn.SetActive(false);
            //计时消失
            timer.SetActive(false);
            Timer.myTimer = 0;
            //显示拍摄按钮
            recordBtn.SetActive(true);              
            //显示提示文字和ok按钮
            tip.SetActive(true);
            okBtn.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
