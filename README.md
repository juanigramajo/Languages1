# Languages1
# rpg-2022-juanigramajo

---

## ESPAÑOL:
(Este proyecto fué realizado en 2022).

_Proyecto final de Taller de Lenguajes I, este proyecto es sobre un mini juego de rol._

El juego es así:
- Si no hay cargados personajes en el JSON:
Se crean 8 personajes con características y datos aleatorios.
- Si hay cargados personajes en el JSON:
El usuario elije jugar con los del JSON o crear nuevos.
Ademas se le pregunta si quiere editar la lista anterior de personajes en el JSON

- Se juega de a dos personas.
- Los jugadores no pueden repetir el personaje.
- Si el personaje muere, hace que el jugador perdedor elija otro con los que van quedando.
- Cuando queda 1 solo personaje lo muestra como ganador y la cantidad de vidas que le quedaron.
- Además, con la API muestro información del personaje ganador, su descripción y en cuantos comics de MARVEL aparece.


Datos del código:
- Para crear el JSON tuve que editar un par de variables del personaje.
- Cuando creo el JSON, el tipo nombre y apodo del personaje se guarda con enteros porque uso enums para esa carga.

---

## ENGLISH:
(This project was made in 2022).

_Final project of Language Workshop I, this project is about a RPG._

The game is like:
- If there are no characters loaded in the JSON:
8 characters are created with random characteristics and data.
- If there are characters loaded in the JSON:
The user chooses to play with the JSON ones or create new ones.
You are also asked if you want to edit the previous list of characters in the JSON

- It is played by two people.
- Players cannot repeat the character.
- If the character dies, it makes the losing player choose another with those who are remaining.
- When there is only 1 character left, it shows him as the winner and the amount of lives he had left.
-In addition, with the API I show information about the winning character, his description and how many MARVEL comics he appears in.


About the code:
- To create the JSON I had to edit a couple of variables of the character.
- When I create the JSON, the type name and nickname of the character is saved with integers because I use enums for that load.