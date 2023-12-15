using System.Text;

namespace Lab1DCSoft;

internal class NonInjury : Participant
{
    public override async void PhysicalConditionAsync()
    {
        using FileStream fstream = new FileStream("NonInjuryOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Физическое состояние участников в норме");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
