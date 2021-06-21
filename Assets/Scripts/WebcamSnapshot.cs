using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamSnapshot : MonoBehaviour
{
    private WebCamTexture camTexture;
    private Texture2D texture;

    // Start is called before the first frame update
    void Start()
    {
        camTexture = new WebCamTexture(640, 480, 2);
        texture = new Texture2D(camTexture.requestedWidth, camTexture.requestedHeight);
        camTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        texture.SetPixels(camTexture.GetPixels());
        byte[] imgArr = ImageConversion.EncodeToJPG(texture);
    }
}
