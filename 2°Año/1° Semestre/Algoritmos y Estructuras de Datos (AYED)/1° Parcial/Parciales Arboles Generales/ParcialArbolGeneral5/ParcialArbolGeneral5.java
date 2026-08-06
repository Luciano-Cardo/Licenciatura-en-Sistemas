package ParcialesArboles;

public class ParcialArbolGeneral5 {
	
	public List<Integer> resolver(GeneralTree<Integer> arbol) {
        List<Integer> camino = new LinkedList<Integer>();
        if (arbol != null && !arbol.isEmpty()) {
            GeneralTree<Integer> nodoActual = arbol;
            camino.add(nodoActual.getData());
            boolean seguirCamino = true;
            while (!nodoActual.isLeaf() && seguirCamino) {
                int posicionHijo = nodoActual.getData(); 
                List<GeneralTree<Integer>> hijos = nodoActual.getChildren();
                if (posicionHijo >= 0 && posicionHijo < hijos.size()) {
                    nodoActual = hijos.get(posicionHijo);
                    camino.add(nodoActual.getData()); 
                } else {
                    seguirCamino = false;
                }
            }
        }
        return camino; 
    }
	
}
