package ParcialesArboles;

import java.util.List;

public class ParcialArbolGeneral22 {
	
	public  List<String> recorrer(GeneralTree<Archivo> arbol, int nivel){
		List<String> lista = new LinkedList<String>();
		int n = 0;
		boolean ok = false;
		if(arbol != null && !arbol.isEmpty()) {
			Queue<GeneralTree<Archivo>> cola = new Queue<GeneralTree<Archivo>>();
			GeneralTree<Archivo> ag = null;
			cola.enqueue(arbol);
			cola.enqueue(null);
			while(!cola.isEmpty() && !ok) {
				ag = cola.dequeue();
				if(ag != null) {
					if(nivel == n) {
						if(ag.getData().esImagen()) {
							lista.add(ag.getData().getNombre());
						}
					}
					if(n < nivel) {
						for(GeneralTree<Archivo> hijo : ag.getChildren()) {
							cola.enqueue(hijo);
						}
					}
				}else {
					if(!cola.isEmpty()) {
						n++;
						if(n > nivel) {
							ok = true;
						}else {
							cola.enqueue(null);
						}
					}
				}
			}
		}
		return lista;
	}
	
}
