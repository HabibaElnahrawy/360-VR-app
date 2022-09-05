using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTourViewer : MonoBehaviour
{
    public Renderer renderer;
    public Texture[] texture;
    public GameObject Gr1_spot, Gr2_spot, Gr3_spot;
    int activeImage_index;

    void Start()
    {
        renderer.material.mainTexture = texture[0];
        activeImage_index = 0;
    }


    public void settexture(int index)
    {
        if (index >= 0 && index<texture.Length)
       {
                renderer.material.mainTexture = texture[index];

          
      }
   }

    public void  Group2(bool Gr_check)
    {
        Gr1_spot.SetActive(false);
        Gr2_spot.SetActive(true);
         Gr3_spot.SetActive(false);
    }
    public void Group1(bool Gr_check)
    {
        Gr1_spot.SetActive(true);
        Gr2_spot.SetActive(false);
        Gr3_spot.SetActive(false); 
    }
    public void Group3(bool Gr_check)
    {
        Gr1_spot.SetActive(false);
        Gr2_spot.SetActive(false);
        Gr3_spot.SetActive(true);
    }

}
