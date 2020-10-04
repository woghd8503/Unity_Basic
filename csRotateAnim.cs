using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAnim : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    Animator anim;

    void FrontImage()
    {
        //GetComponent<Renderer>().material.mainTexture = Resources.Load("image1");
        GetComponent<Renderer>().material = mat1;
    }
    void BackImage()
    {
        //GetComponent<Renderer>().material.mainTexture = Resources.Load("image2");
        GetComponent<Renderer>().material = mat2;
    }

    // addition

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        StartCoroutine("coAnim");
    }

    IEnumerator coAnim()
    {
        anim.SetInteger("aniStep", 1);
        yield return new WaitForSeconds(1.0f);
        anim.SetInteger("aniStep", 0);
    }
}
