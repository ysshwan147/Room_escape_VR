using UnityEngine;

public class Computer : MonoBehaviour
{
    public MeshRenderer mainScreen;
    public MeshRenderer subScreen;

    public Material offMat;
    public Material loginMat;
    public Material sylla1Mat;
    public Material sylla2Mat;

    // Start is called before the first frame update
    void Start()
    {
        turnOffComputer();
    }

    public void turnOnComputer()
    {
        mainScreen.material = loginMat;
    }

    public void turnOffComputer()
    {
        mainScreen.material = offMat;
        subScreen.material = offMat;
    }

    public void loginComputer()
    {
        mainScreen.material = sylla1Mat;
        subScreen.material = sylla2Mat;
    }
}
