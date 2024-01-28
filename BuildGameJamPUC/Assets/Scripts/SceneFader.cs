using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour {

	public Image img;
	public AnimationCurve curve;

	void Start ()
	{
		StartCoroutine(FadeIn());
	}

    private void OnLevelWasLoaded()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo(int scene)
	{
		Debug.Log("Fade to " + scene);
		StartCoroutine(FadeOut(scene));
	}

	public void SkipTime()
	{
		StartCoroutine(AltFadeOut());
	}

	IEnumerator FadeIn ()
	{
		float t = 1f;

		while (t > 0f)
		{
			t -= Time.deltaTime;
			float a = curve.Evaluate(t);
			img.color = new Color (0f, 0f, 0f, a);
			yield return 0;
		}
	}

	IEnumerator FadeOut(int scene)
	{
		float t = 0f;

		while (t < 1f)
		{
			t += Time.deltaTime;
			float a = curve.Evaluate(t);
			img.color = new Color(0f, 0f, 0f, a);
			yield return 0;
		}
			
		SceneManager.LoadScene(scene);
	}

	IEnumerator AltFadeOut()
	{
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
			yield return 0;
        }

		yield return new WaitForSeconds(.5f);
		StartCoroutine(FadeIn());
    }
}
