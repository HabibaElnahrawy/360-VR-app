using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class imagesviewer : MonoBehaviour
{
    public GameObject[] images;
    int activeImage_index;
    public Button next_btn;
    public Button prev_btn;


    public void set_images(int index)
    {
        if (index >= 0 && index < images.Length)
        {

            for (int i = 0; i < images.Length; i++)
            {
                images[i].SetActive(false); // batfi kol el images
            }
            images[index].SetActive(true);
        }
    }
    private void Start()
    {
        set_images(0);
        activeImage_index = 0;
        
    }
    public void  next()
    {
        if (activeImage_index==images.Length-1)
        {
            next_btn.interactable = false;
            return;
        }
        activeImage_index++;
        set_images(activeImage_index);
        prev_btn.interactable = true;

    }
    public void prev()
    {
        if (activeImage_index==0)
        {
            prev_btn.interactable = false;
            return;
        }
        activeImage_index--;
        set_images(activeImage_index);
        next_btn.interactable = true;
    }

}
