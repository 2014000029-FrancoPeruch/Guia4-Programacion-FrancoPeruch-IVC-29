Algoritmo Lecc9_Act3_Inc1
	Definir num, i Como Entero
	
	Escribir "Ingrese un número:"
	Leer num
	
	Si num >= 20 Entonces
		i = 20
		
		Mientras i <= num Hacer
			Si i MOD 2 = 1 Entonces
				Escribir i
			FinSi
			
			i = i + 1
		FinMientras
		
	SiNo
		i = num
		
		Mientras i <= 20 Hacer
			Si i MOD 2 = 1 Entonces
				Escribir i
			FinSi
			
			i = i + 1
		FinMientras
	FinSi
	
FinAlgoritmo
