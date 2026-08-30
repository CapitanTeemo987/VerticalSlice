# La carrera de Teemo

### Descripción y Play Loop
La carrera de Teemo es un juego de laberinto desarrollado en Unity para PC, controlado mediante teclado. El objetivo principal es guiar al personaje Teemo a través de los pasillos del laberinto para alcanzar la meta final mientras escapa de un zombi que lo persigue en todo momento. 

Para poder escapar, el camino directo a la meta está bloqueado por una puerta cerrada. El jugador debe explorar el entorno, localizar y recoger una llave, lo que actualiza instantáneamente el HUD en pantalla y desactiva la puerta para habilitar el paso hacia la salida. Si el zombi logra colisionar con Teemo, la partida se termina de inmediato congelando el tiempo de la escena y mostrando el panel de derrota con el botón de reintento. Pero sii Teemo llega a la meta, se detiene la partida, se disparan partículas de confeti y se activa la pantalla de victoria con la opción de volver a jugar.

### Importante
El HUD depende de donde tengas posicionado la ventana de Game, porfavor pon Game en otra pestaña aparte de Scene

### Recursos Reutilizados y Uso de IA
* **Código base:** En el código de MovimientoJugador reutilice la parte de Update, donde se hace las animaciones y las actualiza, lee la entrada del jugador.

* **Declaración de IA:** Utilice la inteligencia artificial Gemini para poder entender qué hacían las herramientas de NavMesh Surface y NavMesh Agent, considero que el NavMesh es una herramienta muy útil y nada difícil de implementar, en mi código solo cambié una línea, y en unity solo lo tuve que asignar al plano y a las paredes para que hiciera el camino por el cual el agente puede caminar. 


### Créditos y Referencias
* **Modelos 3D de personajes:** *Blocky Characters* por Kenney (Licencia CC0 1.0 Universal - Dominio Público) https://kenney.nl/assets/blocky-characters
* **Modelos de llave y puerta:** *FREE Doors with Keys: Ready to open* por PolyKebap (Unity Asset Store Standard EULA) https://assetstore.unity.com/packages/3d/props/free-doors-with-keys-ready-to-open-349626#content
* Technologies, U. (n.d.). Unity - Scripting API: NAVMeshAgent. https://docs.unity3d.com/6000.5/Documentation/ScriptReference/AI.NavMeshAgent.html
* A guide on using the new AI Navigation package in Unity 2022 LTS and above. (2024, July 11). Unity Discussions. https://discussions.unity.com/t/a-guide-on-using-the-new-ai-navigation-package-in-unity-2022-lts-and-above/371872
* Google. (2026). Gemini (Versión de agosto de 2026) [Modelo de lenguaje grande]. https://gemini.google.com
* Grupos. (n.d.). https://groups.meeplab.com/contenidos/tc2008b/intro-unity/lab1/2-physics-unity
* Technologies, U. (n.d.-a). UI.Button - Unity Scripting API. https://docs.unity3d.com/es/2017.4/ScriptReference/UI.Button.html



