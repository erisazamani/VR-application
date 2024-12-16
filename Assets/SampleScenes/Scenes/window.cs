using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour
{
   public  GameObject Mypublic;
    public  GameObject iwalls;

	 public  GameObject Windowmat;
	
	 public Material matwindow1;
	 public Material matwindow2;
	 public Material matwindow3;
	 
	  public Text textco2;
	 public Text textcost;
	public Slider Slidercost;
	 public Slider Sliderco2;
	 public int costwall1;
	public int costwall2;
	public int costwall3;
	public int costwindow1;
	public int costwindow2;
	public int costwindow3;
	public int costdoor1;
	public int costdoor2;
	public int costdoor3;
	public int costfloor1;
		public int costfloor2;
		public int costfloor3;
		public int co2wall1;
	public int co2wall2;
	public int co2wall3;
	public int co2window1;
	public int co2window2;
	public int co2window3;
	public int co2door1;
	public int co2door2;
	public int co2door3;
	public int co2floor1;
		public int co2floor2;
		public int co2floor3;
	void Start()
    {
     Mypublic = GameObject.Find("mypublic");
	 iwalls = GameObject.Find("iwindows");
	 
	  Windowmat = GameObject.Find("Windowmat");
	  
	  textco2 = GameObject.Find("CO2text").GetComponent<Text>();
	 textcost = GameObject.Find("COSTtext").GetComponent<Text>();
	 Slidercost = GameObject.Find("Slidercost").GetComponent<Slider>();
	 Sliderco2 = GameObject.Find("Sliderco2").GetComponent<Slider>();
	 costwall1 = Mypublic.GetComponent<mypublicscript>().costwall3;
	 costwall2 = Mypublic.GetComponent<mypublicscript>().costwall1;
	 costwall3 = Mypublic.GetComponent<mypublicscript>().costwall2;
	 costwindow1 = Mypublic.GetComponent<mypublicscript>().costwindow3;
	 costwindow2 = Mypublic.GetComponent<mypublicscript>().costwindow1;
	 costwindow3 = Mypublic.GetComponent<mypublicscript>().costwindow2;
	 costdoor1 = Mypublic.GetComponent<mypublicscript>().costdoor3;
	 costdoor2 = Mypublic.GetComponent<mypublicscript>().costdoor1;
	 costdoor3 = Mypublic.GetComponent<mypublicscript>().costdoor2;
	 costfloor1 = Mypublic.GetComponent<mypublicscript>().costfloor3;
	 costfloor2 = Mypublic.GetComponent<mypublicscript>().costfloor1;
	 costfloor3 = Mypublic.GetComponent<mypublicscript>().costfloor2;
	 co2wall1 = Mypublic.GetComponent<mypublicscript>().co2wall3;
	 co2wall2 = Mypublic.GetComponent<mypublicscript>().co2wall1;
	 co2wall3 = Mypublic.GetComponent<mypublicscript>().co2wall2;
	 co2window1 = Mypublic.GetComponent<mypublicscript>().co2window3;
	 co2window2 = Mypublic.GetComponent<mypublicscript>().co2window1;
	 co2window3 = Mypublic.GetComponent<mypublicscript>().co2window2;
	 co2door1 = Mypublic.GetComponent<mypublicscript>().co2door3;
	 co2door2 = Mypublic.GetComponent<mypublicscript>().co2door1;
	 co2door3 = Mypublic.GetComponent<mypublicscript>().co2door2;
	 co2floor1 = Mypublic.GetComponent<mypublicscript>().co2floor3;
	 co2floor2 = Mypublic.GetComponent<mypublicscript>().co2floor1;
	 co2floor3 = Mypublic.GetComponent<mypublicscript>().co2floor2;
	 int x;
	
	}
    void OnMouseDown()
    {      
		int x = Mypublic.GetComponent<mypublicscript>().window;
		
	if(x == 1){
		  		  Mypublic.GetComponent<mypublicscript>().window=2;
				  iwalls.GetComponent<UnityEngine.UI.Text>().text = "Window 1";
				  
				  matwindow1 = Mypublic.GetComponent<mypublicscript>().matwindow1;
				foreach (Transform item in Windowmat.transform)
        {
            item.GetComponent<MeshRenderer>().material = matwindow1;
        }
			Debug.Log(x);
			Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().window1.SetActive(true);
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
				 Mypublic.GetComponent<mypublicscript>().window=3;
				   iwalls.GetComponent<UnityEngine.UI.Text>().text = "Window 2";
				   
				    matwindow2 = Mypublic.GetComponent<mypublicscript>().matwindow2;
				foreach (Transform item in Windowmat.transform)
        {
            item.GetComponent<MeshRenderer>().material = matwindow2;
        }
				   
			Debug.Log( x);
			
			Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(false);
		 
		 Mypublic.GetComponent<mypublicscript>().window1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window2.SetActive(true);
			Mypublic.GetComponent<mypublicscript>().window3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().floor1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().door1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door3.SetActive(false);
		
	} else if(x == 3){
				 Mypublic.GetComponent<mypublicscript>().window=1;
				   iwalls.GetComponent<UnityEngine.UI.Text>().text = "Window 3";
				   
				    matwindow3 = Mypublic.GetComponent<mypublicscript>().matwindow3;
				foreach (Transform item in Windowmat.transform)
        {
            item.GetComponent<MeshRenderer>().material = matwindow3;
        }
				   
			Debug.Log( x);
		
		
		Mypublic.GetComponent<mypublicscript>().wall1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().wall3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().window1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().window3.SetActive(true);
			
			Mypublic.GetComponent<mypublicscript>().floor1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().floor3.SetActive(false);
			
			Mypublic.GetComponent<mypublicscript>().door1.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door2.SetActive(false);
			Mypublic.GetComponent<mypublicscript>().door3.SetActive(false);
	}
		  
		  
        
		
		
		
		
		
		
		
		
		
		
		
		 int nwall = Mypublic.GetComponent<mypublicscript>().wall;
	int nwindow = Mypublic.GetComponent<mypublicscript>().window;
	int nfloor = Mypublic.GetComponent<mypublicscript>().floor;
	int ndoor = Mypublic.GetComponent<mypublicscript>().door;
		if(nwall == 1){
		if(nwindow == 1){
			if(nfloor == 1){
				if(ndoor == 1){
					
					Slidercost.value = costwall1+costwindow1+costfloor1+costdoor1;	
					Sliderco2.value = co2wall1+co2window1+co2floor1+co2door1;							
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow1+costfloor1+costdoor2;
					Sliderco2.value = co2wall1+co2window1+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow1+costfloor1+costdoor3;
					Sliderco2.value = co2wall1+co2window1+co2floor1+co2door2;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow1+costfloor2+costdoor1;	
					Sliderco2.value = co2wall1+co2window1+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow1+costfloor2+costdoor2;	
					Sliderco2.value = co2wall1+co2window1+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow1+costfloor2+costdoor3;	
					Sliderco2.value = co2wall1+co2window1+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow1+costfloor3+costdoor1;	
					Sliderco2.value = co2wall1+co2window1+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow1+costfloor3+costdoor2;	
					Sliderco2.value = co2wall1+co2window1+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow1+costfloor3+costdoor3;	
					Sliderco2.value = co2wall1+co2window1+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 2){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow2+costfloor1+costdoor1;	
					Sliderco2.value = co2wall1+co2window2+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow2+costfloor1+costdoor2;	
					Sliderco2.value = co2wall1+co2window2+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow2+costfloor1+costdoor3;	
					Sliderco2.value = co2wall1+co2window2+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow2+costfloor2+costdoor1;	
					Sliderco2.value = co2wall1+co2window2+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow2+costfloor2+costdoor2;	
					Sliderco2.value = co2wall1+co2window2+co2floor2+co2door2;
		
				}else if(ndoor == 3){
		Slidercost.value = costwall1+costwindow2+costfloor2+costdoor3;	
					Sliderco2.value = co2wall1+co2window2+co2floor2+co2door3;
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow2+costfloor3+costdoor1;	
					Sliderco2.value = co2wall1+co2window2+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow2+costfloor3+costdoor2;	
					Sliderco2.value = co2wall1+co2window2+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow2+costfloor3+costdoor3;	
					Sliderco2.value = co2wall1+co2window2+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 3){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow3+costfloor1+costdoor1;	
					Sliderco2.value = co2wall1+co2window3+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow3+costfloor1+costdoor2;	
					Sliderco2.value = co2wall1+co2window3+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow3+costfloor1+costdoor3;	
					Sliderco2.value = co2wall1+co2window3+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow3+costfloor2+costdoor1;	
					Sliderco2.value = co2wall1+co2window3+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow3+costfloor2+costdoor2;	
					Sliderco2.value = co2wall1+co2window3+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow3+costfloor2+costdoor3;	
					Sliderco2.value = co2wall1+co2window3+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall1+costwindow3+costfloor3+costdoor1;	
					Sliderco2.value = co2wall1+co2window3+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall1+costwindow3+costfloor3+costdoor2;	
					Sliderco2.value = co2wall1+co2window3+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall1+costwindow3+costfloor3+costdoor3;	
					Sliderco2.value = co2wall1+co2window3+co2floor3+co2door3;
		
	}
		
	}
		
	}
		
	}else if(nwall == 2){
		if(nwindow == 1){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow1+costfloor1+costdoor1;	
					Sliderco2.value = co2wall2+co2window1+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow1+costfloor1+costdoor2;	
					Sliderco2.value = co2wall2+co2window1+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow1+costfloor1+costdoor3;	
					Sliderco2.value = co2wall2+co2window1+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow1+costfloor2+costdoor1;	
					Sliderco2.value = co2wall2+co2window1+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow1+costfloor2+costdoor2;	
					Sliderco2.value = co2wall2+co2window1+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow1+costfloor2+costdoor3;	
					Sliderco2.value = co2wall2+co2window1+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow1+costfloor3+costdoor1;	
					Sliderco2.value = co2wall2+co2window1+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow1+costfloor3+costdoor2;	
					Sliderco2.value = co2wall2+co2window1+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow1+costfloor3+costdoor3;	
					Sliderco2.value = co2wall2+co2window1+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 2){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow2+costfloor1+costdoor1;	
					Sliderco2.value = co2wall2+co2window2+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow2+costfloor1+costdoor2;	
					Sliderco2.value = co2wall2+co2window2+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow2+costfloor1+costdoor3;	
					Sliderco2.value = co2wall2+co2window2+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow2+costfloor2+costdoor1;	
					Sliderco2.value = co2wall2+co2window2+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow2+costfloor2+costdoor2;	
					Sliderco2.value = co2wall2+co2window2+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow2+costfloor2+costdoor3;	
					Sliderco2.value = co2wall2+co2window2+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow2+costfloor3+costdoor1;	
					Sliderco2.value = co2wall2+co2window2+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow2+costfloor3+costdoor2;	
					Sliderco2.value = co2wall2+co2window2+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow2+costfloor3+costdoor3;	
					Sliderco2.value = co2wall2+co2window2+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 3){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow3+costfloor1+costdoor1;	
					Sliderco2.value = co2wall2+co2window3+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow3+costfloor1+costdoor2;	
					Sliderco2.value = co2wall2+co2window3+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow3+costfloor1+costdoor3;	
					Sliderco2.value = co2wall2+co2window3+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow3+costfloor2+costdoor1;	
					Sliderco2.value = co2wall2+co2window3+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow3+costfloor2+costdoor2;	
					Sliderco2.value = co2wall2+co2window3+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow3+costfloor2+costdoor3;	
					Sliderco2.value = co2wall2+co2window3+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall2+costwindow3+costfloor3+costdoor1;	
					Sliderco2.value = co2wall2+co2window3+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall2+costwindow3+costfloor3+costdoor2;	
					Sliderco2.value = co2wall2+co2window3+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall2+costwindow3+costfloor3+costdoor3;	
					Sliderco2.value = co2wall2+co2window3+co2floor3+co2door3;
		
	}
		
	}
		
	}
		
	}else if(nwall == 3){
		if(nwindow == 1){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow1+costfloor1+costdoor1;	
					Sliderco2.value = co2wall3+co2window1+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow1+costfloor1+costdoor2;	
					Sliderco2.value = co2wall3+co2window1+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow1+costfloor1+costdoor3;	
					Sliderco2.value = co2wall3+co2window1+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow1+costfloor2+costdoor1;	
					Sliderco2.value = co2wall3+co2window1+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow1+costfloor2+costdoor2;	
					Sliderco2.value = co2wall3+co2window1+co2floor2+co2door2;
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow1+costfloor2+costdoor3;	
					Sliderco2.value = co2wall3+co2window1+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow1+costfloor3+costdoor1;	
					Sliderco2.value = co2wall3+co2window1+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow1+costfloor3+costdoor2;	
					Sliderco2.value = co2wall3+co2window1+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow1+costfloor3+costdoor3;	
					Sliderco2.value = co2wall3+co2window1+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 2){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow2+costfloor1+costdoor1;	
					Sliderco2.value = co2wall3+co2window2+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow2+costfloor1+costdoor2;	
					Sliderco2.value = co2wall3+co2window2+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow2+costfloor1+costdoor3;	
					Sliderco2.value = co2wall3+co2window2+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow2+costfloor2+costdoor1;	
					Sliderco2.value = co2wall3+co2window2+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow2+costfloor2+costdoor2;	
					Sliderco2.value = co2wall3+co2window2+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow2+costfloor2+costdoor3;	
					Sliderco2.value = co2wall3+co2window2+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow2+costfloor3+costdoor1;	
					Sliderco2.value = co2wall3+co2window2+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow2+costfloor3+costdoor2;	
					Sliderco2.value = co2wall3+co2window2+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow2+costfloor3+costdoor3;	
					Sliderco2.value = co2wall3+co2window2+co2floor3+co2door3;
		
	}
		
	}
		
		}else if(nwindow == 3){
			if(nfloor == 1){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow3+costfloor1+costdoor1;	
					Sliderco2.value = co2wall3+co2window3+co2floor1+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow3+costfloor1+costdoor2;	
					Sliderco2.value = co2wall3+co2window3+co2floor1+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow3+costfloor1+costdoor3;	
					Sliderco2.value = co2wall3+co2window3+co2floor1+co2door3;
		
	}
		
			}else if(nfloor == 2){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow3+costfloor2+costdoor1;	
					Sliderco2.value = co2wall3+co2window3+co2floor2+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow3+costfloor2+costdoor2;	
					Sliderco2.value = co2wall3+co2window3+co2floor2+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow3+costfloor2+costdoor3;	
					Sliderco2.value = co2wall3+co2window3+co2floor2+co2door3;
		
	}
		
			}else if(nfloor == 3){
				if(ndoor == 1){
					Slidercost.value = costwall3+costwindow3+costfloor3+costdoor1;	
					Sliderco2.value = co2wall3+co2window3+co2floor3+co2door1;
		
				}else if(ndoor == 2){
					Slidercost.value = costwall3+costwindow3+costfloor3+costdoor2;	
					Sliderco2.value = co2wall3+co2window3+co2floor3+co2door2;
		
				}else if(ndoor == 3){
					Slidercost.value = costwall3+costwindow3+costfloor3+costdoor3;	
					Sliderco2.value = co2wall3+co2window3+co2floor3+co2door3;
		
	}
		
	}
		
	}
		
	}
	
	textco2.text = Sliderco2.value + " Ton";
		  textcost.text = Slidercost.value + "K $";
       if(Slidercost.value < 40){
										Slidercost.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.green;
						}else if(40 < Slidercost.value){
					if(Slidercost.value < 53){
				  Slidercost.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.yellow;
				  }else if(50 < Slidercost.value){
										  Slidercost.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.red;
		  }
	}
	
		  
		  if(Sliderco2.value < 400){
			  Sliderco2.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.green;
			  }else if(400 < Sliderco2.value ){
				  if(Sliderco2.value < 630){
				  Sliderco2.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.yellow;
				  }	  
				  						
				else if(630 < Sliderco2.value){
							Sliderco2.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.red;
					  
		  }
			  }
    }
}
