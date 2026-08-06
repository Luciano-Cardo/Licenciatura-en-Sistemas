package PracticaArbolesGenerales;

public class punto4 {
	
	public double devolverMaximoPromedio (GeneralTree<AreaEmpresa>arbol) {
		int promedio = 0;
		int suma = 0;
		int elementos = 0;
		int maxPromedio = Integer.MIN_VALUE;	
		if(arbol != null && !arbol.isEmpty()) {
			Queue<GeneralTree<AreaEmpresa>> cola = new Queue<GeneralTree<AreaEmpresa>>();
			GeneralTree<AreaEmpresa> ag = null;
			cola.enqueue(arbol);
			cola.enqueue(null);
			while(!cola.isEmpty()) {
				ag = cola.dequeue();
				if(ag != null) {
					elementos += 1;
					suma += ag.getData().getTardanza();
					for(GeneralTree<AreaEmpresa> hijo : ag.getChildren()) {
						cola.enqueue(hijo);
					}
				}else {
					promedio = suma/elementos;
					if(promedio > maxPromedio) {
						maxPromedio = promedio;
					}
					elementos = 0;
					suma = 0;
					if(!cola.isEmpty()) {
						cola.enqueue(null);
					}
				}
			}
		}
		return maxPromedio;
	}
	
}
