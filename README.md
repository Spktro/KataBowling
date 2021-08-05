# Kata Bowling


## Enunciado
Dado una secuencia válida de tiradas de bolos, devolver la puntuación total de la
partida.

## Simplificaciones:
• No comprobar la validez de las tiradas. <br />
• No comprobar el número de tiradas. <br />
• No proporcionar puntuaciones intermedias <br />

## Reglas de puntuación:
• Cada partida se compone de 10 turnos. <br />
• Hay 10 bolos que se intentan tirar en cada turno. <br />
• En cada turno el jugador hace 2 tiradas. <br />
• Si en un turno el jugador no tira los 10 bolos, la puntuación del turno es el total
de bolos tirados. <br />
• Si en un turno el jugador tira los 10 bolos (un "spare"), la puntuación es 10 más
el número de bolos tirados en la siguiente tirada (del siguiente turno). <br />
• Si en la primera tirada del turno tira los 10 bolos (un "strike") el turno acaba y la
puntuación es 10 más el número de bolos de las dos tiradas siguientes. <br />
• Si el jugador logra un spare o un strike en el último turno, obtiene una o dos
tiradas más (respectivamente) de bonificación. Esas tiradas cuentan como
parte del mismo turno (el décimo). <br />
• Si en las tiradas de bonificación el jugador derriba todos los bolos, el proceso
no se repite, es decir que no se vuelven a generar más lanzamientos de
bonificación. <br />

**Nota**: el puntaje generado en las tiradas de bonificación se suma a la
puntuación del turno final. <br />




