Sprint 0 - Game Design Document : Tower Defense

Naam: Sammy Verdam

Klas: SD2A

Datum: 8 – 9 - 2025

1. Titel en elevator pitch
Titel: Tower Blast
Erg interactief, leuke towers en het is heel fast paced. Goed om je tijd te verdoen.

2. Wat maakt jouw tower defense uniek
Het wordt een 3D Tower defense. Dit spel wordt super leuk met een simpel design niet te complex.

3. Schets van je level en UI
![Schets](https://github.com/Ymmas1968/Tower-Defense/blob/main/Schets.png)
Toren 1 Patrick, grote range, 40% damage, Sniper.
Toren 2 Edward, Short range, 20% damage, Schiet heel snel.
Eventuele extra torens:

5. Vijanden
Vijand 1 Jackson, sloom, 3 hit, groot character.
Vijand 2 Bill, snel, 1 damage per hit, super snel.
Eventuele extra vijanden:

6. Gameplay loop
Beschrijf in drie tot vijf stappen wat de speler steeds doet. 1.
2.	Farm geld

3.	Plaats troops

4.	Kill enemies

5.	repeat

7. Progressie
De enemies krijgen meer HP en je gaat een ronde omhoog als alle enemies worden gekilled. 

8. Risico’s en oplossingen volgens PIO

•	Probleem 1: enemies volgen het pad niet

•	Impact: de game loopt niet goed

•	Oplossing: een vast traject geven

•	Probleem 2: Health system die het niet doet

•	Impact: Je kan dan niet verliezen

•	Oplossing: Kijken naar de health system en proberen te fixen

•	Probleem 3: Coins system werkt niet

•	Impact: Je kan de geen nieuwe troops kopen en sloopt de game een beetje

•	Oplossing: De coinsysteem fixen

9. Planning per sprint en mechanics
Schrijf per sprint welke mechanics jij oplevert in de build. Denk aan voorbeelden zoals vijandbeweging over een pad, torens plaatsen, doel kiezen en schieten, waves starten, UI voor geld en levens, upgrades, jouw unieke feature.

Sprint 1 mechanics: Het pad maken

Sprint 2 mechanics: De enemies erin zetten

Sprint 3 mechanics: Plaats mechanic

Sprint 4 mechanics: Money mechanic 

Sprint 5 mechanics: Health mechanic 

10. Inspiratie
Mijn inspiratie is bloons td6

Noem een bestaande tower defense game die jou inspireert en wat je daarvan meeneemt of juist vermijdt.

11. Technisch ontwerp mini
Lees dit korte voorbeeld en vul daarna jouw eigen keuzes in.
Voorbeeld ingevuld bij

11.1 Vijandbeweging over het pad

•	Keuze: Vijanden volgen punten A, B, C en daarna de goal.

•	Risico: Een vijand loopt een punt voorbij of blijft hangen.

•	Oplossing: Als de vijand dichtbij genoeg is kiest hij het volgende punt. Bij de goal gaat één leven omlaag en verdwijnt de vijand.

•	Acceptatie: Tien vijanden lopen van start naar de goal zonder vastlopers en verbruiken elk één leven. Alle tien vijanden bereiken achtereenvolgens elk waypoint binnen één seconde na elkaar.

11.1 Vijandbeweging over het pad

•	Keuze: VIjdan beweging naar d waypoints

•	Risico: dat ze van het pad kunnen raken als ik de waypoint niet heb geplaatst

•	Oplossing: Misschien de waypoint hoger plaatsen

•	Acceptatie: wanneer die de 3 waypoints goed volgt

11.2 Doel kiezen en schieten

•	Keuze: Torens kunnen vijanden selecteren en automatisch schieten.

•	Risico: Dat torens geen doel kiezen of blijven richten op een vijand die al dood is.

•	Oplossing: Script maken dat automatisch het dichtstbijzijnde vijand selecteert, en checkt of die nog leeft.

•	Acceptatie:Torens schieten altijd op de dichtstbijzijnde vijand zolang die in range is.

11.3 Waves en spawnen

•	Keuze: Vijanden verschijnen in golven (bijvoorbeeld 10 vijanden per wave).

•	Risico: Dat vijanden allemaal tegelijk spawnen of dat de timing verkeerd is.

•	Oplossing: spawner script gebruiken die vijanden één voor één spawnt met een delay.

•	Acceptatie: Vijanden verschijnen in de juiste volgorde en met een constante interval

11.4 Economie en levens

•	Keuze: Speler krijgt geld voor elke vijand die verslagen wordt, en verliest levens als vijanden de goal bereiken.

•	Risico: Dat de balans niet klopt (te veel of te weinig geld/levens).

•	Oplossing: Variabelen instelbaar maken in de Inspector zodat balans getest en aangepast kan worden.

•	Acceptatie: Speler kan torens bouwen zolang hij genoeg geld heeft, en het spel eindigt als levens op 0 zijn.

11.5 UI basis

•	Keuze: UI toont levens, geld en wave nummer.

•	Risico: Dat UI niet goed wordt bijgewerkt of overlapt met de game view.

•	Oplossing: Gebruik van canvas en text components, en scripts die UI updaten bij elke change.

•	Acceptatie: Speler ziet altijd hoeveel levens, geld en welke wave bezig is.
