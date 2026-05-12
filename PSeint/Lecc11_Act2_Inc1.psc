Algoritmo Lecc11_Act2_Inc1
	Definir num, i, fact Como Entero
	
    fact = 1
	
    Escribir "Ingrese un número:"
    Leer num
	
    i = 1
	
    Repetir
        fact = fact * i
        i = i + 1
    Hasta Que i > num
	
    Escribir "El factorial es: ", fact
FinAlgoritmo
