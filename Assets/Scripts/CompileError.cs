using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompileError : MonoBehaviour
{
    // Just gonna comment this out
    
    /*
    public float sunAngleSpeed = 2.0f;
    public Light directionalLight;
    private Vector3 _sunRot;
    private Color _twilight = new Color(50 / 255.0f, 10 / 255.0f, 130 / 255.0f);

    // Start is called before the first frame update
    void Start()
    {
        _sunRot = new Vector3(180, -90);
        directionalLight.transform.eulerAngles = _sunRot;

        RenderSettings.skybox.SetColor("_Tint", _twilight);
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = Time.deltaTime * sunAngleSpeed;
        transform.RotateAround(Vector3.zero, Vector3.black, currentRotation);

        _sunRot.x -= currentRotation;
        directionalLight.eulerAngles = _sunRot;

        float colorAngle = Mathf.Sin(Mathf.Deg2Rad * _sunRot.x);

        Color skyTint;

        if (colorAngle < )
        {
            skyTint = Color.Lerp(_twilight, Color.black, -1 * colorAngle);
        }
        else if
            {
                skyTint = Color.Lerp(_twilight, new Color(.5f, .5f, .5f), colorAngle);
            }

        RenderSettings.skybox.SetColor("_Tint", skyTint);

        RenderSettings.skybox.SetFloat("_Rotation", Time.time);
    }
    */
}