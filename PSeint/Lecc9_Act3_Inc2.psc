Algoritmo Lecc9_Act3_Inc2
	Definir num, i, cont Como Entero
	
    i = 1
    cont = 0
	
    Escribir Sin Saltar "Ingrese un número entero: "
    Leer num
	
    Mientras i <= num Hacer
        Si num MOD i = 0 Entonces
            cont = cont + 1
        FinSi
		
        i = i + 1
    FinMientras
	
    Si cont = 2 Entonces
        Escribir "El número es primo"
    SiNo
        Escribir "El número no es primo"
    FinSi
FinAlgoritmo
