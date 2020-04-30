using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class szSuperHOTeffect : MonoBehaviour
{
	
	
	public float MIN_SCALE = 0.01f;
	
	public float CapVelocity = .1f;
	
	public GameObject Controller1;
	
	
	
	private Vector3 PrevController1;
	
    // Start is called before the first frame update
    void Start()
    {	SetPrevState();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = Controller1.transform.position - PrevController1;
		
		
		float totalVel = 2* mov.magnitude ;
		
		Time.timeScale = (totalVel / CapVelocity) + MIN_SCALE;
		
		SetPrevState();
    }
	
	void SetPrevState() 
	{
		PrevController1 = Controller1.transform.position;
	}
	
}
