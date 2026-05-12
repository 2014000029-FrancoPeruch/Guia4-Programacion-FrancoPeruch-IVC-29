Algoritmo Lecc11_Act1_Inc1
	Definir autos, disp Como Entero
	autos <- 0
	disp <- 200
	Repetir
		Escribir 'Cajones disponibles: ', disp
		autos <- autos+1
		disp <- disp-1
	Hasta Que disp=0
	Escribir 'Ya no hay cajones libres'
FinAlgoritmo
