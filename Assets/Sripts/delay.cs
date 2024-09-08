using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class ShowButtonDelayed : MonoBehaviour
{
    public float delay = 10f; // The delay in seconds.
    public GameObject myPanel; // Reference to the UI button.
    public AudioSource a;

    private CanvasGroup canvasGroup;

    private void Start()
    {
        // Get the CanvasGroup component of the button.
        canvasGroup = myPanel.GetComponent<CanvasGroup>();

        // Initially, make the button invisible.
        canvasGroup.alpha = 0;

        // Start the coroutine to show the button after the delay.
        StartCoroutine(ShowButtonAfterDelay());
    }

    private IEnumerator ShowButtonAfterDelay()
    {
        // Wait for the specified delay.
        yield return new WaitForSeconds(delay);

        // Make the button visible by changing the CanvasGroup's alpha property.
        canvasGroup.alpha = 1;
        a.Play();

    }
}
