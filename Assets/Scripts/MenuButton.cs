using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    [SerializeField] AnimatorFunctions animatorFunctions;
    [SerializeField] int thisIndex;

    void Update()
    {
        if (menuButtonController.index == thisIndex)
        {
            animator.SetBool("selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("pressed", true);
            }
            else if (animator.GetBool("pressed"))
            {
                animator.SetBool("pressed", false);
                animatorFunctions.disableOnce = true;
            }
        }
        else
        {
            animator.SetBool("selected", false);
        }

        // Check if the "Enter" key is pressed to quit the game
        if (Input.GetKeyDown(KeyCode.Return) && menuButtonController.index == 2)
        {
            // Start the coroutine to wait and then quit
            StartCoroutine(QuitAfterDelay(0.5f));
        }
    }

    IEnumerator QuitAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Quit the game
        Application.Quit();

        // If running in the Unity Editor, stop playing the scene
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif

        Debug.Log("Game is exiting");
    }
}