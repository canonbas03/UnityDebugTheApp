using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh text;
    public ParticleSystem SparksParticles;

    public List<string> textToDisplay;

    private float rotatingSpeed = 0f;
    private float timeToNextText;

    private int currentText;

    Vector3 rotation = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        timeToNextText = 0.0f;
        currentText = 0;

        rotatingSpeed = 1.0f;

        textToDisplay.Add("Congratulation!");
        textToDisplay.Add("All Errors Fixed");

        text.text = textToDisplay[0];

        SparksParticles.Play();

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0,rotatingSpeed,0);
        rotatingSpeed += Time.deltaTime * 10;
        timeToNextText += Time.deltaTime;

        if (timeToNextText > 3.5f)
        {
            if (currentText >= textToDisplay.Count - 1)
            {
                text.text = textToDisplay[currentText];
                currentText = 0;


            }
            else
            {

                text.text = textToDisplay[currentText];
                currentText++;
            }
            timeToNextText = 0.0f;
        }
    }
}