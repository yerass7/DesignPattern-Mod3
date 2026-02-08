# Design Pattern – SOLID Principles Implementation

Бұл репозиторийде **SOLID принциптері** негізінде C# тілінде жасалған мысалдар бар.  
Әр принцип бөлек папкада орналасқан және оның міндеттері мен жауапкершіліктері бөлек көрсетілген.

---

##  Папкалар мен сипаттамасы

### SRP – Single Responsibility Principle
- Папка: `SRP/`
- Класстар тек **бір ғана жауапкершілікке** ие:
  - `Order.cs` – тапсырыс деректерін сақтайды
  - `PriceCalculator.cs` – бағасын есептейді
  - `PaymentProcessor.cs` – төлемді өңдейді
  - `EmailService.cs` – растайтын email жібереді

### OCP – Open-Closed Principle
- Папка: `OCP/`
- Жалақы есептеу логикасы **ашық өзгеріске, жабық өзгертуге** арналған:
  - `Employee.cs` – қызметкер деректері
  - `ISalaryCalculator.cs` – интерфейс
  - `PermanentSalaryCalculator.cs`, `ContractSalaryCalculator.cs`, `InternSalaryCalculator.cs` – әр типке арналған есептеу

### ISP – Interface Segregation Principle
- Папка: `ISP/`
- Принтерлер үшін интерфейстер **тек қажет функционалға** арналған:
  - `IPrinter.cs`, `IScanner.cs`, `IFax.cs`
  - `AllInOnePrinter.cs` – барлық функциялар
  - `BasicPrinter.cs` – тек басып шығару

### DIP – Dependency Inversion Principle
- Папка: `DIP/`
- NotificationService **абстракцияға тәуелді**, нақты классқа емес:
  - `INotificationSender.cs` – интерфейс
  - `EmailSender.cs`, `SmsSender.cs` – нақты имплементациялар
  - `NotificationService.cs` – интерфейс арқылы хабарлама жібереді

---

## Қолдану

`Program.cs` файлы арқылы әр принципті тексеруге болады:

```csharp
var emailService = new NotificationService(new EmailSender());
emailService.SendNotification("Hello via Email");

var smsService = new NotificationService(new SmsSender());
smsService.SendNotification("Hello via SMS");
