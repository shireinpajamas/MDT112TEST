using System;


public class Program
{
	 int a,b,x,y;
	public void Main()
	{		
		a = Int32.Parse(Console.ReadLine());
		b = Int32.Parse(Console.ReadLine());
		x=a;
		y=b;
		while(x!=y){
			if(x<y){
			x=x+a;
			}
			else{
			y=y+b;
			}
		}
		Console.Write(x);
	}	
}