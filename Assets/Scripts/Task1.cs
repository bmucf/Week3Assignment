using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Task1 : MonoBehaviour
{
    public string courseName;
    [Range(1, 10)] public int numberOfModules;
    [Range(1, 10)] public int numberOfReadingMaterials;
    [Range(1, 10)] public int numberOfQuizzes;
    [Range(1, 10)] public int numberOfAssignments;
    public bool isTheInstructorExperienced;

    private float courseChallenge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float modulePoints = (numberOfModules / 10) * 15;
        courseChallenge = modulePoints;
        Debug.Log(courseName + " has a difficulty rating of " + courseChallenge + "/10.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
