Algoritmo Lecc28_Act2_Inc1y2
	Definir tipo, totalBoletos, totalDinero, op Como Entero
		
	totalBoletos = 0
	totalDinero = 0
	op = 1
	
	Mientras op = 1 Hacer
		
		Escribir "========================"
		Escribir "1. Adulto ($15)"
		Escribir "2. Niño ($10)"
		Escribir "========================"
		Escribir "Ingrese el tipo de boleto:"
		Leer tipo
		
		Si tipo = 1 Entonces
			totalDinero <- totalDinero + 15
			totalBoletos <- totalBoletos + 1
		SiNo
			Si tipo = 2 Entonces
				totalDinero <- totalDinero + 10
				totalBoletos <- totalBoletos + 1
			FinSi
		FinSi
		
		Escribir "Boletos vendidos: ", totalBoletos
		Escribir "Total cobrado: $", totalDinero
		
		Escribir "¿Desea vender otro boleto?"
		Escribir "1. Sí"
		Escribir "2. No"
		Leer op
		
	FinMientras
	
	Escribir "========================"
	Escribir "Ventas finalizadas"
	Escribir "Boletos vendidos: ", totalBoletos
	Escribir "Total recaudado: $", totalDinero
	
FinAlgoritmo
