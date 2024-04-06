using UnityEngine;

public class UnityMethods : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake method called");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable method called");
    }

    void Start()
    {
        Debug.Log("Start method called");
    }

    void Update()
    {
        Debug.Log("Update method called");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate method called");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate method called");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable method called");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy method called");
    }
}