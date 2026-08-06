package PracticaArbolesGenerales;

public class punto3 {
	
	public int altura() {
	    if (this.isLeaf()) {
	        return 0;
	    }
	    int alturaMax = -1;
	    for (GeneralTree<Integer> hijo : this.getChildren()) {
	        alturaMax = Math.max(alturaMax, hijo.altura());
	    }
	    return 1 + alturaMax; 
	}
	
	public int nivel(T dato) {
	    Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
	    GeneralTree<Integer> aux;
	    int nivelActual = 0;
	    cola.enqueue(this);
	    cola.enqueue(null); 
	    while (!cola.isEmpty()) {
	        aux = cola.dequeue();
	        if (aux != null) {
	            if (aux.getData().equals(dato)) {
	                return nivelActual;
	            }
	            for (GeneralTree<Integer> hijo : aux.getChildren()) {
	                cola.enqueue(hijo);
	            }
	        } else if (!cola.isEmpty()) {
	            nivelActual++;
	            cola.enqueue(null);
	        }
	    }
	    return -1; 
	}
	
	public int ancho() {
	    Queue<GeneralTree<Integer>> cola = new Queue<GeneralTree<Integer>>();
	    GeneralTree<Integer> aux;
	    int maxAncho = 0;
	    int nodosEnNivel = 0;
	    cola.enqueue(this);
	    cola.enqueue(null);
	    while (!cola.isEmpty()) {
	        aux = cola.dequeue();
	        if (aux != null) {
	            nodosEnNivel++;
	            for (GeneralTree<Integer> hijo : aux.getChildren()) {
	                cola.enqueue(hijo);
	            }
	        } else {
	        	if(nodosEnNivel > maxAncho) {
	        		maxAncho = nodosEnNivel;
	        	}
	            if (!cola.isEmpty()) {
	                nodosEnNivel = 0;
	                cola.enqueue(null);
	            }
	        }
	    }
	    return maxAncho;
	}
	
}
