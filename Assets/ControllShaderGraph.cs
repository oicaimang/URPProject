using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllShaderGraph : MonoBehaviour
{
    public Material MaterialA;
    public float FloatFrom1;
    public float FloatFrom2;
    public float FloatFrom3;
    public float FloatFrom4;
    public float FloatTo1;
    public float FloatTo2;
    public float FloatTo3;
    public float FloatTo4;


    // Start is called before the first frame update
    void Start()
    {
        FloatFrom1=MaterialA.GetFloat("FloatFrom1");
        FloatFrom2=MaterialA.GetFloat("FloatFrom2");
        FloatFrom3=MaterialA.GetFloat("FloatFrom3");
        FloatFrom4=MaterialA.GetFloat("FloatFrom4");

        FloatTo1=MaterialA.GetFloat("FloatTo1");
        FloatTo2=MaterialA.GetFloat("FloatTo2");
        FloatTo3=MaterialA.GetFloat("FloatTo3");
        FloatTo4=MaterialA.GetFloat("FloatTo4");
    }

    // Update is called once per frame
    void Update()
    {
        var cosX=Mathf.Cos(this.transform.rotation.eulerAngles.z*3.14f/180);
        Debug.Log(cosX);
        MaterialA.SetFloat("FloatFrom1",FloatFrom1*cosX);
        MaterialA.SetFloat("FloatFrom2",FloatFrom2*cosX);
        MaterialA.SetFloat("FloatFrom3",FloatFrom3*cosX);
        MaterialA.SetFloat("FloatFrom4",FloatFrom4-FloatFrom4*cosX*0.3f);

        MaterialA.SetFloat("FloatTo1",FloatTo1*cosX);
        MaterialA.SetFloat("FloatTo2",FloatTo2*cosX);
        MaterialA.SetFloat("FloatTo3",FloatTo3*cosX);
        MaterialA.SetFloat("FloatTo4",FloatTo4*cosX);

    }
}
