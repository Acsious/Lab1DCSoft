using Lab1_D_CSoft;
using Lab1DCSoft;

RoadAccidentsToday roadAccidentsToday = new RoadAccidentsToday();

Console.WriteLine("Отчет о дорожных проишествиях сегодня: ");

Console.WriteLine("\nМелкое дтп: ");
roadAccidentsToday.smallCrash.CreateDamage().InsuranceAssessment();
roadAccidentsToday.smallCrash.CreateInjury().PhysicalCondition();

Console.WriteLine("\nКрупное дтп: ");
roadAccidentsToday.largeCrash.CreateDamage().InsuranceAssessment();
roadAccidentsToday.largeCrash.CreateInjury().PhysicalCondition();

