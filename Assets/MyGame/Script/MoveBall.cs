using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour {

    //  public GameObject BallPosTopLeft;
    //  public GameObject BallPosBottomLeft;
    //  public GameObject BallPosBottomRight;
    //  public GameObject BallPosTopRight;

    [SerializeField] private GameObject[] BallPositions;
    [SerializeField] private GameObject[] ball;

    public void MoveTheBall () {
        Debug.Log (Random.Range (0, 1));
    }
}