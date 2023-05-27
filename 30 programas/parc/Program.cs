/*
 * Created by SharpDevelop.
 * User: maic_
 * Date: 08/12/2020
 * Time: 07:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace parc
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			int rep=1;
			int parc=0;
			while (rep==1) {
				int prog=0;
				Console.WriteLine("Parcial 1");
			    Console.WriteLine("Parcial 2");
		        Console.WriteLine("Parcial 3");
		        parc=int.Parse(Console.ReadLine());
		        if (parc==1){
				Console.WriteLine("Parcial 1");
		        Console.WriteLine("1.- Operaciones ");
			    Console.WriteLine("2.- Area Circulo");
			    Console.WriteLine("3.- Area Triangulo");
			    Console.WriteLine("4.- Operadores Logicos");
			    Console.WriteLine("5.- Par O Impar");
			    Console.WriteLine("6.- Promedio");
			    Console.WriteLine("7.- Sed");
			    Console.WriteLine("8.- Bisiesto");
			    Console.WriteLine("Selecciona numero de programa");
			    prog=int.Parse(Console.ReadLine());
			    switch(prog){
			    		case 1:
	Console.WriteLine("Operaciones");
	Sumar();
	Console.ReadKey();
	break;
case 2:
	Console.WriteLine("Area Circulo");
	double rad=0,a;
	Console.WriteLine("Dame radio");
	rad=double.Parse(Console.ReadLine());
	a = AreaCirc(rad);
	Console.WriteLine(a);
	Console.ReadKey();
	break;
case 3:
	Console.WriteLine("Area triangulo");
	double alt,bas,area;
	Console.WriteLine("Dame altura");
	alt=double.Parse(Console.ReadLine());
	Console.WriteLine("Dame base");
	bas=double.Parse(Console.ReadLine());
	area= AreaCirc(alt,bas);
	Console.WriteLine(area);
	Console.ReadKey();
	break;
case 4:
	Console.WriteLine("Operadores logicos");
	Logicos();
	
	Console.ReadKey();
	break;
case 5:
	Console.WriteLine("Par O Impar");
	ParOImpar();
	Console.ReadKey();
	break;
case 6:
	Console.WriteLine("Promedio");
	Promedio();
	Console.ReadKey();
	break;
case 7:
	Console.WriteLine("Sed");
	Sed();
	Console.ReadKey();
	break;	
case 8:
	Console.WriteLine("Bisiesto");
	Bisiesto();
	Console.ReadKey();
	break;		
			    }    
				
			    
			}
   if (parc==2){
		        	Console.WriteLine("Parcial 2");
		        Console.WriteLine("9.- Semaforo ");
			    Console.WriteLine("10.- Menu");
			    Console.WriteLine("11.- Suma 89");
			    Console.WriteLine("12.- Multiplos 3");
			    Console.WriteLine("13.- Factorial");
			    Console.WriteLine("14.- Numeros");
			    Console.WriteLine("15.- Fibonacci");
			    Console.WriteLine("16.- Numeros mayores a 100");
                Console.WriteLine("17.- Triangulo");
			    Console.WriteLine("18.- Serie");
			    Console.WriteLine("19.- Menores a 0, Mayores a 0, Iguales a 0");   
			    Console.WriteLine("20.- Maria");   
		        Console.WriteLine("Selecciona numero de programa");
			    prog=int.Parse(Console.ReadLine());	
			       switch(prog){
			    case 9:
	Semaforo();
	Console.ReadKey();
	break;		
case 10:
	Menu();
	Console.ReadKey();
	break;	
case 11:
	Suma89();
	Console.ReadKey();
	break;	
case 12:
	Multiplos3();
	Console.ReadKey();
	break;		
case 13:
	int  fa=0;
	Console.WriteLine("Numero a calcular factorial");
	fa=int.Parse(Console.ReadLine());
	
	Console.WriteLine(Facto(fa));
	Console.ReadKey();
	break;	
case 14:	
	Numeros();
	Console.ReadKey();
	break;
case 15:
	int n1=0;
	Console.WriteLine("Fibonacci");
	Console.WriteLine("Limite");
	n1=int.Parse(Console.ReadLine());
	Console.WriteLine(Fibo(n1));
	Console.ReadKey();
	break;	   
case 16:	
	Console.WriteLine("Numeros mayores a 100"); 
	NumeroMenor10();
	Console.ReadKey();
	break;   
case 17:
	Console.WriteLine("Triangulo");
	Triang();
	Console.ReadKey();
	break;
case 18:
	int n=0;
	Console.WriteLine("Serie");
	n=int.Parse(Console.ReadLine());
	Console.WriteLine(Serie(n));
	Console.ReadKey();
	break;
case 19:
	Console.WriteLine("Menores a 0, Mayores a 0, Iguales a 0");
	Nums();
	Console.ReadKey();
	break;
case 20:
	Console.WriteLine("Maria");
	Maria();
	Console.ReadKey();
	break;		
		        }
				
		        }
			
		        if(parc==3){
		        Console.WriteLine("Parcial 3");
		        Console.WriteLine("21.- Posicion O -1");
			    Console.WriteLine("22.- Multpiplicacion vectores");
			    Console.WriteLine("23.- Burbuja");
			    Console.WriteLine("24.- Multiplicacion matrices");
			    Console.WriteLine("25.- Mayor de cada fila"); 
			    Console.WriteLine("26.- Suma de la diagonal"); 
			    Console.WriteLine("27.- Es multiplo");  
		        Console.WriteLine("Selecciona numero de programa");
			    prog=int.Parse(Console.ReadLine());	  
			    switch(prog){
			    		case 21:
                     	Console.WriteLine("Posicion O -1");
	                    Posicion();
	                    Console.ReadKey();
                      	break;
                        case 22:
	                    Console.WriteLine("Multiplicacion Vectores");
	                    multVectores();
	                   Console.ReadKey();
	                   break;
                      case 23:
	                  Console.WriteLine("Burbuja");
                    	Burbuja();
	                  Console.ReadKey();
	             break;
	              case 24:
	                  Console.WriteLine("Multiplicacion Matrices");
                    	MultMat();
	                  Console.ReadKey();
	             break; 
	              case 25:
	                  Console.WriteLine("Mayor cada fila");
                        MayorFila();
	                  Console.ReadKey();
	             break; 
	              case 26:
	                  Console.WriteLine("Suma Diagonal");
                        sumaDiagonal();
	                  Console.ReadKey();
	             break; 
	            case 27:
	             Console.WriteLine("Multiplo");
	             EsMultiplo();
	             break;
	}
			    }
			}}
		        
			
			
			public static void Sumar(){
	
	float n1, n2,Suma=0,Sum=0,Su=0,S=0;
	Console.WriteLine("Dame numero 1");
	n1=float.Parse(Console.ReadLine());
	Console.WriteLine("Dame numero 1");
	n2=float.Parse(Console.ReadLine());
	Suma=n1+n2;
	Sum=n1-n2;
	Su=n1*n2;
	S=n1/n2;
	Console.WriteLine(Suma);
	Console.WriteLine(Sum);
	Console.WriteLine(Su);
	Console.WriteLine(S);
	
	}
	
	public static double AreaCirc(double a){
	
	double Area= 3.1416*a*3.1416*a;
	return Area;
	}
	public static double AreaCirc(double alt, double bas){
	
	double ar= alt*bas/2;
	return ar;
	}
	public static void Logicos(){
	bool uno;
	bool dos;
	bool and;
	bool or;
	bool negacionUno,negacionDos;
	Console.WriteLine("Valor primera variable");
	uno=Convert.ToBoolean(Console.ReadLine());
	Console.WriteLine("Valor segunda variable");
	dos=Convert.ToBoolean(Console.ReadLine());
	and= uno && dos;
	or= uno || dos;
	negacionUno= !uno;
	negacionDos= !dos;
	Console.WriteLine("El valor de {0} y {1} es {2}",uno,dos,and);
	Console.WriteLine("El valor de {0} o {1} es {2}",uno,dos,or);
	Console.WriteLine("El valor de negar {0} es {1}",uno,negacionUno);
	Console.WriteLine("El valor de negar {0} es {1}",dos,negacionDos);
	
	}
	public static void ParOImpar(){
	double n1=0;
	Console.WriteLine("Numero 1 ");
	n1=double.Parse(Console.ReadLine());
	
	if (n1%2==0){
	Console.WriteLine("Numero par ");
	}else{
	Console.WriteLine("Numero impar ");
	}
	
	}
	public static void Promedio(){
	float cal1=0,cal2=0,cal3=0,promedio=0,suma=0;
	Console.WriteLine("Calificacion 1");
	cal1=float.Parse(Console.ReadLine());
	Console.WriteLine("Calificacion 2");
	cal2=float.Parse(Console.ReadLine());
	Console.WriteLine("Calificacion 3");
	cal3=float.Parse(Console.ReadLine());
	suma=cal1+cal2+cal3;
	promedio=suma/3;
	if (promedio>=9){
	Console.WriteLine("Buena", promedio);
	
	}else if (promedio>=7 & promedio<=9){
	
	Console.WriteLine("Regular", promedio);
	}else{
	Console.WriteLine("Reprobado", promedio);
	}
	}
	
	public static void Sed(){
	char res,res2;
	Console.WriteLine("¿Sed?");
	res=Convert.ToChar(Console.ReadLine());
	Console.WriteLine("¿Dinero?");
	res2=Convert.ToChar(Console.ReadLine());
	if(res=='s' & res2=='s'){
	Console.WriteLine("Compra una botella de agua");
	}else if (res=='n' & res2=='s'){
	
	Console.WriteLine("Compra un chocolate");
	}else{
	Console.WriteLine("No tienes dinero ve a casa");
	}
	}
	public static void Bisiesto(){
	float a=0;
	Console.WriteLine("Dame año");
	a=float.Parse(Console.ReadLine());
	if(a%400==0){
	Console.WriteLine("Es bisiesto");
	}else if(a%4==0 & a%100==0) {
	Console.WriteLine("Es bisiesto");
	}else{
	Console.WriteLine("No es bisiesto");
	}}
		public static void Semaforo(){
	int color;
	Console.WriteLine("Semaforo");
	color=int.Parse(Console.ReadLine());
	switch(color){
case 1:
	Console.WriteLine("Verde");
	break;
case 2:
	Console.WriteLine("Amarillo");
	break;
case 3:
	Console.WriteLine("Rojo");
	break;	
	}
	
	}
	public static void Menu(){
	char signo;
	float num1,num2;
	Console.WriteLine("Numero 1");
	num1=float.Parse(Console.ReadLine());
	Console.WriteLine("Numero 1");
	num2=float.Parse(Console.ReadLine());
	Console.WriteLine("Signo de la operacion que desea hacer:");
	signo=Convert.ToChar(Console.ReadLine());
	float op;
	switch(signo){
case '+':
	op=num1+num2;
	Console.WriteLine(op);
	break;
case '-':
	op=num1-num2;
	Console.WriteLine(op);
	break;
case '/':
	op=num1/num2;
	Console.WriteLine(op);
	break;	
case '*': 
	op=num1*num2; 
	Console.WriteLine(op);
	break;		
	}
	}
	public static void Suma89(){
	int Suma=0;
	for(int i=0; i<=89; i++){
	Suma=Suma+i;	
	}
	Console.WriteLine(Suma);
	}
	public static void Multiplos3(){
	int Suma=0;
	for(int i=0; i<=100; i=i+3){
	Suma=Suma+i;	
	}
	Console.WriteLine(Suma);
	}
	public static int Facto(int f){
	
	int	fact=1;
	for(int i=1; i<=f; i++){
	fact=fact*i;
	Console.WriteLine(fact);
	
	}
	return fact;
	}
	public static void Numeros(){
	float promedio=0,sum2=0,n=0,div=0,sum=0;
	for(int i=1; i<=6; i++){
	Console.WriteLine("Dame numero: ", i);
	n=float.Parse(Console.ReadLine());
	if(n>=0){
	div=div+1;
	sum=sum+n;
	}else if (n<0){
	sum2=sum2+n;
	}else{
	Console.WriteLine("No hay numeros positivos");
	}
	
	}promedio=sum/div;
	Console.WriteLine(promedio);
	Console.WriteLine(sum2);
	}
	public static int Fibo(int num){
	int n=0,n2=1;
	int fibo=0;
	for(int i=1; i<num; i++){
	Console.WriteLine(n);
	fibo=n+n2;
	n=n2;
	n2=fibo;
	
	}
	return n;
	}
	public static void NumeroMenor10(){
	
	int  num=0;
	do{
	
	Console.WriteLine("Leer");
	num=int.Parse(Console.ReadLine());
	}
	while(num>100);
	}
	public static void Triang(){
	int espacio,trian,num=0;
	Console.WriteLine("Dame base");
	num=int.Parse(Console.ReadLine());
	for(int i=1; i<=num; i++){
	for(espacio=1; espacio<=num-i; espacio++){
	Console.Write(" ");
	}
	for(trian=1; trian<=i; trian++){
	Console.Write("* ");
	
	}
	Console.WriteLine("");
	}
	
	}
	public static int Serie(int a){
	int multi=1, acum=1;	
	for(int i=2; i<=a; i=i+2){
	for(int j=1; j==1; j++){
	multi=i*j;
	acum=acum*multi;
	Console.WriteLine(acum);
	
	}
	
	}
	return acum; 
	}
	public static void Nums(){
	int num=0,a=0,b=0,c=0;
	char res='s';
	while(res=='s'){
	Console.WriteLine("Dame numero");
	num=int.Parse(Console.ReadLine());
	if(num>0){
	a=a+1;
	}else if(num<0){ 		
	b=b+1;
	}else{
	c=c+1;
	}
	Console.WriteLine("Desea Colocar Mas Numeros S/N");
	res=Convert.ToChar(Console.ReadLine());
	}
	
	Console.WriteLine("Numeros Mayores A 0" );
	Console.WriteLine(a);
	Console.WriteLine("Numeros Menores A 0" );
	Console.WriteLine(b);
	Console.WriteLine("Numeros Iguales A 0");	
	Console.WriteLine(c);
	}
	public static void Maria(){
	int acum=50,edad=11;
	do{
	edad=edad+1;
	acum=acum*2;
	} while(edad<18);
	Console.WriteLine("Edad");
	Console.WriteLine(edad);
	Console.WriteLine("Pago");
	Console.WriteLine(acum);
	}
			public static void Posicion(){
	int num=0, posicion, bandera;
	int [] n = new int [10];
	int i;
	for (i=0; i<10; i++){
	n[i]=int.Parse(Console.ReadLine());
	}
	Console.WriteLine("Dame numero");
	num=int.Parse(Console.ReadLine());
	posicion=-1;
	bandera=0;
	for(i=0; i<10; i++){
	if(num==n[i]){
	posicion=i;
	Console.WriteLine("Posicion: ");
	Console.WriteLine(posicion);
	bandera=1;
	}
	
	}
	if(bandera==0){
	Console.WriteLine("-1");
	}
	}
	public static void multVectores(){
	int suma=0;
	int [] n = new int [11];
	int [] n2 = new int [11];
	int [] n3 = new int [11];
	for(int i=1; i<=10; i++){
	n[i]=i;
	for(int j=1; j<=10; j++){		
	n2[j]=j;
	n3[i]=n[i]*n2[j];
	Console.WriteLine(n[i]+"*"+n2[j]+"="+n3[i]);
	suma=n3[i]+suma;
	}
	} Console.WriteLine("Suma");
	Console.WriteLine(suma) ;
	
	}
	public static void Burbuja(){
	int v=0,aux;
	int [] burbuja = new int [11];
	v=10;
	for(int i=1; i<=v; i++){
	Console.WriteLine("Valores");
	burbuja[i]=int.Parse(Console.ReadLine());
	}
	for(int i=1; i<v; i++){
	for(int g=1; i<v-i+1; i++){
	if(burbuja[g]>burbuja[g+1]){
	aux=burbuja[g];
	burbuja[g]=burbuja[g+1];
	burbuja[g+1]=aux;
	
	
	}
	
	}
	}
	Console.WriteLine("Vector Ordenado");
	for(int i=1; i<=v; i++){
	Console.WriteLine(i+","+burbuja[i]);
	}
		}
		public static void MultMat(){
			int suma=0,sum2=0,sum1=0;
			int [,] mult1= new int[4,4];
			
			int i=0, j=0;
			for(i=0; i<4; i++){
				sum1=sum1+1;
				for(j=0; j<4; j++){
					mult1[i,j]=sum1;
					
				}
				
			}
			int [,] mult2= new int[4,4];
		   for(i=0; i<4; i++){
				sum2=sum2+1;
				for(j=0; j<4; j++){
					mult2[i,j]=sum2;
					
				}
				
			}
		int [,] mult3= new int[4,4];
		  for(i=0; i<4; i++){
				for(j=0; j<4; j++){
				    mult3[i,j]=mult1[i,j]*mult2[i,j];
				    suma=mult3[i,j]+suma;
				    Console.WriteLine(mult1[i,j]+"*"+mult2[i,j]+"="+mult3[i,j]);
				}
				
			}
		Console.WriteLine("Suma: " +suma);
		}
		public static void MayorFila(){
		int [,] Matriz= new int[4,4];
		int i=0, j=0,may;
		for(i=0; i<4; i++){
			may=0;
			for(j=0; j<4; j++){
			Matriz[i,j]=int.Parse(Console.ReadLine());
			if(Matriz[i,j]>may){
				may=Matriz[i,j];
			}
		}
		Console.WriteLine("El mayor de la fila "+i+" es "+ may);
	 
	
		}}
		public static void sumaDiagonal(){
			int [,] Matriz= new int[4,4];
			int i=0,j=0,suma=0;
			for(i=0; i<4; i++){
				for(j=0; j<4; j++){
					Matriz[i,j]=int.Parse(Console.ReadLine());	
					if(i==j){	
					 suma=suma+Matriz[i,j];
					}
				}
				
			}
			Console.WriteLine("Suma de la diagonal: "+suma);
		}
		public static void EsMultiplo(){
			int num1,num2;
			Console.WriteLine("Dame numero 1");
			num1=int.Parse(Console.ReadLine());
			Console.WriteLine("Dame numero 2");
			num2=int.Parse(Console.ReadLine());
			if (num1%num2==0){
				Console.WriteLine("Numero " +num1+ " es multiplo de " +num2);
			}else{
				Console.WriteLine("Numero " +num1+ " es multiplo de " +num2);
			}
		}
	
	
	}}