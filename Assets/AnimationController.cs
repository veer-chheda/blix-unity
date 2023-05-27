using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    public float[] pauseTimestamps = {3f,6f,9f,11.9f}; // Array of timestamps to pause the animation
    private int currentIndex = 0; // Index variable to track the current pause condition

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (currentIndex < pauseTimestamps.Length && Time.time >= pauseTimestamps[currentIndex])
        {
            animator.enabled = false; // Disable the Animator component to pause the animation
            currentIndex++;
            Debug.Log("Pause" + Time.time);
            Time.timeScale = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Check for spacebar key press
        {
            animator.enabled = true; // Enable the Animator component to resume or restart the animation
            Debug.Log("Play" + Time.time);
            Time.timeScale = 1f;
        }
    }
}
