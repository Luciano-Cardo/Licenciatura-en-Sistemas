package ParcialesArboles;

public class ParcialArbolGeneral12 {
	
	public GeneralTree<string> tesoroAccesibleMasCercano (GeneralTree<String> camaras){
		GeneralTree<String> tesoro = null;
		boolean encontro = false;
		if(camaras != null && !camaras.isEmpty()) {
			Queue<GeneralTree<String>> cola = new Queue<GeneralTree<String>>();
			GeneralTree<String> ag = null;
			cola.enqueue(camaras);
			while(!cola.isEmpty() && !encontro) {
				ag = cola.dequeue();
				if(!encontro) {
					if(ag.getData().equals("Tesoro")) {
						tesoro = ag;
						encontro = true;
					}
					if(!encontro) {
						for(GeneralTree<String> hijo : ag.getChildren()) {
							if(!hijo.getData().equals("Bloqueo")) {
								cola.enqueue(hijo);
							}
						}
					}
				}
			}
		}
		return tesoro;
	}
	
}
