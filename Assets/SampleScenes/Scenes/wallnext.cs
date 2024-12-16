using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallnext : MonoBehaviour
{
     public  GameObject Mypublic;
	
	void Start()
    {
     Mypublic = GameObject.Find("mypublic");
	 int x;
	
	}
	
	 
   public void mywallnext()
    {      
		int x = Mypublic.GetComponent<mypublicscript>().wall;
		
	if(x == 1){
		  		  Mypublic.GetComponent<mypublicscript>().wall=2;
			Debug.Log(x);
			Mypublic.GetComponent<mypublicscript>().wall1.SetActive(true);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().window1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().floor1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().door1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door3.SetActive(false);
 
    } 
	else if(x == 2){
				 Mypublic.GetComponent<mypublicscript>().wall=3;
			Debug.Log( x);
			
			Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(true);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(false);
		 
			Mypublic.GetComponent<mypublicscript>().window1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window3.SetActive(false);
					
			Mypublic.GetComponent<mypublicscript>().floor1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().door1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door3.SetActive(false);
		
	} 
	else if(x == 3){
				 Mypublic.GetComponent<mypublicscript>().wall=1;
			Debug.Log( x);
		
		
		Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(true);
			
			Mypublic.GetComponent<mypublicscript>().window1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().floor1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().door1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door3.SetActive(false);
	}
		  
		  
        
       
    }
}
