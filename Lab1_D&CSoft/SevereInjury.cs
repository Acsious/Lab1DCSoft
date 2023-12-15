using System.Text;

namespace Lab1DCSoft;

internal class SevereInjury : Participant
{
    public override async void PhysicalConditionAsync()
    {
        using FileStream fstream = new FileStream("SevereInjuryOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Участники находятся в тяжелом физическом состоянии");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
