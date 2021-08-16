﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopBtnController : MonoBehaviour
{
    public GameObject restartBtn;
    public GameObject stopBtn;
    public Timer timer;
    public VideoRecording.RecordingSample videoRecord;
    public GameObject FbxObject;

    private void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        restartBtn.SetActive(true);
        stopBtn.SetActive(false);
        timer.gameObject.SetActive(false);
        timer.Initialize();
        videoRecord.SampleStop();
        FbxObject.SetActive(false);
    }
}
