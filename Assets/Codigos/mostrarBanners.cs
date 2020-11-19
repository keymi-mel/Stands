using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class mostrarBanners : MonoBehaviour
{
    public RawImage miImagen;
    public RawImage miImagen2;
    public RawImage miImagen3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ImagenDB());
    }
    IEnumerator ImagenDB()
    {
        UnityWebRequest conn = UnityWebRequestTexture.GetTexture("http://localhost/DB/prueba.php?name=Video&pss=1234");
        yield return conn.SendWebRequest();
        miImagen.texture = DownloadHandlerTexture.GetContent(conn);
        miImagen2.texture = DownloadHandlerTexture.GetContent(conn);
        miImagen3.texture = DownloadHandlerTexture.GetContent(conn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
