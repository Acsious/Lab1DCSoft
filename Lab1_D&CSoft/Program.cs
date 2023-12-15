using Lab1_D_CSoft;
using Lab1DCSoft;

RoadAccidentsToday roadAccidentsToday = new RoadAccidentsToday();

Console.WriteLine("Отчет о дорожных проишествиях сегодня: ");

Console.WriteLine("\nМелкое дтп: ");
roadAccidentsToday.smallCrash.CreateDamage().InsuranceAssessmentAsync();
roadAccidentsToday.smallCrash.CreateInjury().PhysicalConditionAsync();

Console.WriteLine("\nКрупное дтп: ");
roadAccidentsToday.largeCrash.CreateDamage().InsuranceAssessmentAsync();
roadAccidentsToday.largeCrash.CreateInjury().PhysicalConditionAsync();

