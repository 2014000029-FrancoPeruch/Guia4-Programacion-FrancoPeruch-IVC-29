Algoritmo Lecc15_Act3_Inc1
	Definir i, mult, suma, pares Como Entero
	
    suma = 0
    pares = 0
	
    Para i = 1 Hasta 20 Hacer
        mult = 7 * i
		
        suma = suma + mult
		
        Si mult MOD 2 = 0 Entonces
            pares = pares + 1
        FinSi
    FinPara
	
    Escribir "La sumatoria es: ", suma
    Escribir "Cantidad de múltiplos pares: ", pares
FinAlgoritmo
