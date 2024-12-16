using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose : MonoBehaviour
{
     public  GameObject Mypublic;
	   
	
	void Start()
    {
     Mypublic = GameObject.Find("mypublic");
	
	 int x;
	
	}
	



    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
             
            
                Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
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
			
		 if(Input.GetKeyDown(KeyCode.Escape)){ // capture screen shot on left mouse button down
		 
		 Mypublic.GetComponent<mypublicscript>().MainForm1.SetActive(true);
		 Mypublic.GetComponent<mypublicscript>().Mainmodel.SetActive(false);
		 
		 Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
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


        }
    }

	
	 