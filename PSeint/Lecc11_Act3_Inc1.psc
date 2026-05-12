Algoritmo Lecc11_Act3_Inc1
	Definir num1, num2, men, may, suma, i Como Entero
	
    suma = 0
	
    Escribir "Ingrese el primer número:"
    Leer num1
	
    Escribir "Ingrese el segundo número:"
    Leer num2
	
    Si num1 < num2 Entonces
        men = num1
        may = num2
    SiNo
        men = num2
        may = num1
    FinSi
	
    i = men
	
    Repetir
        suma = suma + i
        i = i + 1
    Hasta Que i > may
	
    Escribir "La suma es: ", suma
FinAlgoritmo
