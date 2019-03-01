using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript MyCanvasInstance;

    // Start is called before the first frame update
    void Start()
    {
        if (MyCanvasInstance == null)
        {
            MyCanvasInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
