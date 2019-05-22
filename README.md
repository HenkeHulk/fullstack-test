# SOLID fee calculator

## Uppgifter

Du har tre uppgifter:

* Vi har fått in buggrapporter om att kostnaden för att lägga upp annonser är fel
så en genomgång av koden behövs för att hitta och åtgärda buggen.
* Koden är i dåligt skick och vi vill att den refaktoreras så att den är i ett
sådant skick att du själv skulle vilja underhålla den.
* Vi vill också att du implementerar en ny feature: I koden du har fått är avslutningsrabatten enligt nedan endast implementerad för auktioner, men vi skulle vilja att den fungerar även för "Köp nu".

## Förutsättningar

Det finns i det här exemplet två typer av annons:

* Auktion (Auction)
* Köp nu (BuyItNow)

Det finns två olika typer av användare:

* Företagsanvändare (Company)
* Användare som ej är företagare (Normal)

## Underlag för beräkning

Formeln för att räkna ut kostnaden för att lägga upp en annons är följande:

* För företag: annonstypens kostnad – rabatt + 4% av annonsens pris.
* För andra användare: annonstypens kostnad – rabatt + 7% av annonsens pris.

Kostnader:

| Annonstyp         | Kostnad
| ----------------- | ------:
| Auktion (Auction) | 25 kr
| Köp nu (BuyItNow) | 35 kr

Rabatter:

* Om en annons slutar idag så dras 10 kronor i rabatt.
* Som företagsanvändare så får du 5 kronor rabatt vid upplägg.

## Kom igång

Koden är skriven i C# och körs i .Net Core. Följ installationsanvisningarna på https://www.microsoft.com/net/ och kör följande i kommandoraden för att köra koden:
> cd src
> dotnet run --project SolidFeeCalculator 1 0 100 '2017-01-01'

Testerna körs genom att ställa sig i src-katalogen och köra:
> dotnet test
