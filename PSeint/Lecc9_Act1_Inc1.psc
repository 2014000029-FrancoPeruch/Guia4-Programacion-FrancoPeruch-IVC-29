Algoritmo Lecc9_Act1_Inc1
	Definir pesomanzana, pesototal, cont Como Entero
	
	//Inicializar la variable
	pesototal =  0
	cont = 0
	
	Mientras pesototal < 1000 Hacer
		Escribir Sin Saltar "Ingrese el peso de la manzana comprada: "
		leer pesomanzana
		
		Si pesomanzana >= 180 Entonces
			pesototal = pesototal + pesomanzana
			Escribir "Leva un peso total de: ", pesototal, " gramos."
			cont = cont + 1
		SiNo
			Escribir "ERROR - La manzana debe de pesar al menos 180 gramos."
		Fin Si
		
		
	Fin Mientras
	
	Escribir "Ya se alcanzó el kilo de peso en manzanas."
	Escribir "Usted compró: ",cont," manzanas."
	
FinAlgoritmo
