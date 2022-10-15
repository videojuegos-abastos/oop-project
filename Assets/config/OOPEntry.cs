using UnityEngine;


public class OOPEntry : MonoBehaviour
{
	void Start()
	{

		string[] args = new string[] { "Program.exe" };
		OOPProject.Program.Main(args);
	
	}
}

public static class Console {

	public static void Log(string s) {
		Debug.Log(s);
	}

}