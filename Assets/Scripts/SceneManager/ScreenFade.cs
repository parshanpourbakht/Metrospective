/************************************************************************************
Copyright   :   Copyright 2014 Oculus VR, LLC. All Rights reserved.
Licensed under the Oculus VR Rift SDK License Version 3.3 (the "License");
you may not use the Oculus VR Rift SDK except in compliance with the License,
which is provided at the time of installation or download, or which
otherwise accompanies this software in either electronic or hard copy form.
You may obtain a copy of the License at
http://www.oculus.com/licenses/LICENSE-3.3
Unless required by applicable law or agreed to in writing, the Oculus VR SDK
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
Modified by: Gerald McAlister
************************************************************************************/

using UnityEngine;
using System.Collections; // required for Coroutines

/// <summary>
/// An enumerator used to describe the type of fade
/// that was done for a fade event.
/// </summary>
public enum FadeType
{
    In, Out
}

/// <summary>
/// The event handler for when the screen fade changes.
/// Called once the screen is fully faded in or out.
/// </summary>
/// <param name="sender">The camera game object calling the fade event.</param>
/// <param name="fadeType">The type of fading the occured (In or Out)</param>
public delegate void FadeChangeHandler(object sender, FadeType fadeType);

/// <summary>
/// Fades the screen from black after a new scene is loaded.
/// </summary>
public class ScreenFade : MonoBehaviour
{
    public static ScreenFade instance;
    /// <summary>
    /// How long it takes to fade.
    /// </summary>
    public float fadeTime = 2.0f;

    /// <summary>
    /// The initial screen color.
    /// </summary>
    public Color fadeColor = new Color(0.01f, 0.01f, 0.01f, 1.0f);

    /// <summary>
    /// The material being used for fading.
    /// </summary>
	private Material fadeMaterial = null;
    /// <summary>
    /// True when the screen is being faded curretnly, false otherwise.
    /// </summary>
	private bool isFading = false;
    /// <summary>
    /// The fade instruction that tells the co-routine to wait until end of frame.
    /// </summary>
	private readonly YieldInstruction fadeInstruction = new WaitForEndOfFrame();

    /// <summary>
    /// A boolean indicating whether the screen is fading currently.
    /// </summary>
	public bool Fading
    {
        get
        {
            return isFading;
        }
    }

    /// <summary>
    /// The event called when fading has changed.
    /// </summary>
	public event FadeChangeHandler FadeChanged;

    /// <summary>
    /// Initialize.
    /// </summary>
    void Awake()
    {
        instance = this;
        // create the fade material
        fadeMaterial = new Material(Shader.Find("Oculus/Unlit Transparent Color"));
    }

    /// <summary>
    /// Starts the fade in
    /// </summary>
    void OnEnable()
    {
        StartCoroutine(FadeIn());
    }

    /// <summary>
    /// Starts a fade in when a new level is loaded
    /// </summary>
    void LevelWasLoaded(int level)
    {
        StartCoroutine(FadeIn());
    }

    /// <summary>
    /// Cleans up the fade material
    /// </summary>
    void OnDestroy()
    {
        if (fadeMaterial != null)
        {
            Destroy(fadeMaterial);
        }
    }

    /// <summary>
    /// Fades the screen in or out.
    /// </summary>
    /// <param name="fadeType">The <see cref="FadeType"/> to use when fading (e.g. fade in or out)</param>
	public void Fade(FadeType fadeType)
    {
        switch (fadeType)
        {
            case FadeType.In:
                StartCoroutine(FadeIn());
                break;
            case FadeType.Out:
                StartCoroutine(FadeOut());
                break;
        }
    }

    /// <summary>
    /// Fades alpha from 1.0 to 0.0
    /// </summary>
    IEnumerator FadeIn()
    {
        float elapsedTime = 0.0f;
        fadeMaterial.color = fadeColor;
        Color color = fadeColor;
        isFading = true;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            color.a = 1.0f - Mathf.Clamp01(elapsedTime / fadeTime);
            fadeMaterial.color = color;
        }
        isFading = false;
        if (FadeChanged != null)
        {
            FadeChanged(gameObject, FadeType.In);
        }
    }

    /// <summary>
    /// Fades alpha from 0.0 to 1.0
    /// </summary>
    IEnumerator FadeOut()
    {
        float elapsedTime = 0.0f;
        fadeMaterial.color = fadeColor;
        Color color = fadeColor;
        isFading = true;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsedTime / fadeTime);
            fadeMaterial.color = color;
        }
        isFading = false;
        if (FadeChanged != null)
        {
            FadeChanged(gameObject, FadeType.Out);
        }
    }

    /// <summary>
    /// Renders the fade overlay when attached to a camera object
    /// </summary>
    void OnPostRender()
    {
        if (isFading)
        {
            fadeMaterial.SetPass(0);
            GL.PushMatrix();
            GL.LoadOrtho();
            GL.Color(fadeMaterial.color);
            GL.Begin(GL.QUADS);
            GL.Vertex3(0f, 0f, -12f);
            GL.Vertex3(0f, 1f, -12f);
            GL.Vertex3(1f, 1f, -12f);
            GL.Vertex3(1f, 0f, -12f);
            GL.End();
            GL.PopMatrix();
        }
    }
}