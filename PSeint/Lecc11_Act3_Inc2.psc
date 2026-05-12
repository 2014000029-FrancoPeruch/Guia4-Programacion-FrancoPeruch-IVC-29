Algoritmo Lecc11_Act3_Inc2
	Definir num, suma Como Entero
	
    suma = 0
	
    Repetir
        Escribir Sin Saltar "Ingrese un número: "
        Leer num
		
        Si num <> 9 Entonces
            suma = suma + num
        FinSi
		
    Hasta Que num = 9
	
    Escribir "La suma total es: ", suma
FinAlgoritmo
