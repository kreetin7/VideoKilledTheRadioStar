using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

	//public GameObject []  ScreenCube;
	//public GameObject[] cubes; 

	public GameObject CubePrefab;

	 GameObject [] Cubeclones = new GameObject[20]; 
	//public GameObject[] cubes;
	private int numofCubes = 10;


	public int CountDownTime;
	public int RevealTime;

	private float timer;
	private int cloneIndex;
	
	

	// Use this for initialization
	void Start () {
		//cubes = new GameObject[numofCubes];
		timer = 1;

		//StartCoroutine(Timer()); 

		for (int i = 0; i < 20; i++)
		{
			Cubeclones [i] = Instantiate(CubePrefab, new Vector3((transform.position.x*i*-0.15f), transform.position.y,0f ), Quaternion.identity) as GameObject;
			//cubes [i].SetActive(true);
			//CubePrefab.SetActive(true);
		}
		print((Cubeclones.Length));
		cloneIndex = Cubeclones.Length;

		//cubes [i].SetActive(true);
		//for (int i = 0; i < numofCubes; i++)
		//{
		//cubes [i] = Instantiate(ScreenCube[i]) as GameObject;

		/*	if (i > 0)
			{
				cubes[i].transform.parent = cubes[i - 1].transform; 
			}
			
			cubes[i].SetActive(true);*/
		//}



	}
	
	// Update is called once per frame
	void Update () {

		if (timer > 0)
		{
			timer -= Time.deltaTime;
		}

		else
		{
			Destroy((Cubeclones[cloneIndex -1 ]));
			cloneIndex--;
			timer = 1;
		}

		
			/*if (CountDownTime > 1f)
			{
				for (int i = Cubeclones.Length; i > 0; i--)
				{
					
				}
					
					
				
			}*/ 
		
		
	}

	IEnumerator Timer()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			CountDownTime++; 

		}
	}
}
