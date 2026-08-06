package ParcialesArboles;

public class ParcialArbolGeneral24 {
	
	public int contar(GeneralTree<Integer> arbol, int valor) {
		int cantidad = 0;
		if(arbol != null && !arbol.isEmpty()){
			cantidad = recorrrer(arbol,valor,0,0);
		}
		return cantidad;
	}
	
	private int recorrer(GeneralTree<Integer> arbol, int valor,int suma) {
		int total=0; 
		suma += arbol.getData();
		if(arbol.isLeaf()) {
			if(suma == valor) {
				total = 1;
			}
		}else {
			for(GeneralTree<Integer> hijo : arbol.getChildren()) {
				total += recorrer(arbol,valor,suma,total);
			} 
		}
		return total;
	}
	
}
