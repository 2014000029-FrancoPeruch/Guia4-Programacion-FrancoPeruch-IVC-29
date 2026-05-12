Algoritmo Lecc15_Act2_Inc1
	Definir num, i, cont, cantidad, suma Como Entero
	
    cantidad = 0
    suma = 0
	
    Para num = 1 Hasta 100 Hacer
        cont = 0
		
        Para i = 1 Hasta num Hacer
            Si num MOD i = 0 Entonces
                cont = cont + 1
            FinSi
        FinPara
		
        Si cont = 2 Entonces
            cantidad = cantidad + 1
            suma = suma + num
        FinSi
    FinPara
	
    Escribir "Cantidad de números primos: ", cantidad
    Escribir "Suma de números primos: ", suma
	
FinAlgoritmo
