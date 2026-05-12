Algoritmo Lecc15_Act3_Inc2
	Definir num, i, cont, cantidadPrimos, sumaPares Como Entero
	
    cantidadPrimos = 0
    sumaPares = 0
	
    Para num = 300 Hasta 1 Con Paso -1 Hacer
		
        Si num MOD 2 = 0 Entonces
            sumaPares <- sumaPares + num
        FinSi
		
        cont = 0
		
        Para i = 1 Hasta num Hacer
            Si num MOD i = 0 Entonces
                cont = cont + 1
            FinSi
        FinPara
		
        Si cont = 2 Entonces
            cantidadPrimos = cantidadPrimos + 1
        FinSi
		
    FinPara
	
    Escribir "Cantidad de números primos: ", cantidadPrimos
    Escribir "Suma de números pares: ", sumaPares
FinAlgoritmo
