using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{
    public Transform transform;
    public InputField inputX;
    public InputField inputY;
    public InputField inputZ;
    public InputField Moveangle;
    public Text text;
    public Button start;
    Vector3 point;
    string X;
    string Y;
    string Z;
    string moveangle;
    float angle;
    float axis;
   

    void Start()
    {
        inputX = GameObject.Find("InputX").GetComponent<InputField>();
        inputY = GameObject.Find("InputY").GetComponent<InputField>();
        inputZ = GameObject.Find("InputZ").GetComponent<InputField>();
        Moveangle = GameObject.Find("MoveAngle").GetComponent<InputField>();
        start = GameObject.Find("Start").GetComponent<Button>();
        transform = GameObject.Find("Cube").GetComponent<Transform>();
    }

    void SetAction()
    {
        X = inputX.text;
        Y = inputY.text;
        Z = inputZ.text;
        moveangle = Moveangle.text;
        float x = float.Parse(X);
        float y = float.Parse(Y);
        float z = float.Parse(Z);
        float angle = float.Parse(moveangle);
        point = new Vector3(x, y, z);
        Debug.Log("aaa");
        start.onClick.AddListener(Action);

    }
    void Action() {
        transform.RotateAround(point, transform.up, angle);

    }


    void Update()
    {


    }

    //        this.transform.RotateAround(new Vector3(x, y, z), transform.rotation, 45 * Time.deltaTime);
    //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
    //        transform.rotation = Quaternion.Euler(x, y, z);


}




//Debug.log(a);
//this.transform.rotation = Quaternion.Euler(move, 0.0f, 0.0f);
