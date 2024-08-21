using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class FadeToBlack : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] float fadeSpeed;
    // Start is called before the first frame update
    public void FadeIn()
    {
        StartCoroutine(FadeImage(1));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeImage(0));
    }

    IEnumerator FadeImage(float targetAlpha)
    {
        float alpha = image.color.a;
        while (Mathf.Abs(alpha - targetAlpha) > 0.05f)
        {
            alpha = Mathf.MoveTowards(alpha, targetAlpha, fadeSpeed * Time.deltaTime);
            image.color = new Color(0, 0, 0, alpha);
        }
        yield return null;
    }
}
