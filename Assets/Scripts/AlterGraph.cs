using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterGraph : MonoBehaviour
{
    [SerializeField]
    private SpriteMask mask;

    [SerializeField]
    private GameObject label;

    private bool showingLabel = false;

    private bool canShowLabel = false;

    private void Awake()
    {
        label.SetActive(false);
    }

    private void Update()
    {
        mask.alphaCutoff = 1 - Input.GetAxis("A");

        if (canShowLabel && Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            if (!showingLabel)
            {
                StartCoroutine(ShowLabel());
            }
        }
    }

    private IEnumerator ShowLabel()
    {
        showingLabel = true;
        label.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        label.SetActive(false);
        showingLabel = false;
    }

    private void OnGUI()
    {
        canShowLabel = GUILayout.Toggle(canShowLabel, "  -  Show Pressed State.");
    }
}
