# Rubrica

Programma c# in wpf che replica una rubrica di contatti e persone leggendo i dati necessari da due file .csv

Stato del programma all'avvio:

![image](https://github.com/APA2306/Rubrica/assets/127589937/c2ceaed2-c5e1-413f-9841-abac1202cf96)

Il programma funziona tramite due classi, una crea la rubrica contatti (nell'immagine soprastante a destra) e l'altra la rubrica persone (a sinistra nell'immagine soprastante).
Le classi sono relativamente semplici e entrambe hanno un costruttore che divide una stringa mandata dal main che a sua volta l'ha letta dal file .csv per poi trasforla in diversi dati necessari per la creazione del contatto, l'unica differenza effettiva è che nella classe contatto abbiamo usato un Enum per definire il tipo di contatto.

Classe contatto:

![image](https://github.com/APA2306/Rubrica/assets/127589937/6042aed6-a612-4b5a-b255-7a7c8f94f241)

Il main del programma come citato prima invece legge i due file .csv tramite l'utilizzo di StreamReader e li manda alle classi rispettive riga per riga.

Main del programma:

![image](https://github.com/APA2306/Rubrica/assets/127589937/018548aa-8ebd-4a10-a8eb-86b53d53a08a)



