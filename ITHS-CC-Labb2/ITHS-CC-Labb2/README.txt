CLEAN CODE LABB 2 AV MALTE HERNANDEZ

Jag har använt mig av Single Responsibility för att bryt ur alla processer för Normal, Quick och
Lightningspeed för att kunna läsa koden tydligare och kunna navigera solution explorern enklare. Varje
Klass är nu ensamstående.

Jag Gjorde Logger och EmailHandler interfaces för jag tyckte dom var tillräckligt olika för att separera
dom och sedan använda dom som abstrakta interfaces som används i program.cs vilket följer 
dependency-inversion

Jag tog bort order Service eftersom det var den som inte föll någon utav SOLID och istället använder mig
av min egna OrderHandler som ser mycket snyggare ut. If satsen är densamma då den kräver att visa moment
följs i en specifik ordning
