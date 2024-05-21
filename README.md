# personalregister
Uppgift 1: Vilka klasser bör ingå i programmet?

    Employee: En klass för att representera en anställd. Den hanterar namn och lön för varje anställd.

    EmployeeRegister: En klass för att hantera en samling av anställda typ en lista. Den tillåter att anställda läggs till i registret och kan skriva ut registret.

Uppgift 2: Vilka attribut och metoder bör ingå i dessa klasser?
Employee-klassen:

    Attribut:
        Name: En sträng för att lagra namnet på de anställda.
        Salary: En decimal för att lagra lönen för de anställda.

    Metoder:
        Employee(string name, decimal salary): Konstruktorn för att skapa en ny instans av Employee med angivet namn och lön.
        ToString() gör så att Employee-objektet blir en sträng.

EmployeeRegister-klassen:

    Attribut:
        employees: En lista som håller en samling av Employee-objekt.

    Metoder:
        AddEmployee(string name, decimal salary): Lägger till en ny anställd i registret med det angivna namnet och lönen.
        PrintRegister(): Skriver ut alla anställda i registret till konsolen.

Program-klassen:

    Main(string[] args): Huvudmetoden för programmet där användaren interagerar med konsolen för att lägga till anställda i registret och skriva ut det.
