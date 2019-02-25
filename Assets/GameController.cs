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
        transform = GameObject.Find("Cube").GetComponent<Transform>();
           }

    // Update is called once per frame
    void Update()
    {
        X = inputX.text;
        Y = inputY.text;
        Z = inputZ.text;
        moveangle = Moveangle.text;
        float x = float.Parse(X);
        float y = float.Parse(Y);
        float z = float.Parse(Z);
        float move = float.Parse(moveangle);
        //transform.Rotate(new Vector3(x,y,z));
        
        this.transform.RotateAround(new Vector3(x, y, z), transform.up, 45 * Time.deltaTime);
        Debug.log(a);
        //this.transform.rotation = Quaternion.Euler(move, 0.0f, 0.0f);
        //transform.RotateAround(new Vector3(x,y,z),transform.up, 45 * Time.deltaTime);
    }

}
