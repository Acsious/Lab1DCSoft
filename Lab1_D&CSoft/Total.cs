using System.Text;

namespace Lab1DCSoft;
internal class Total : Vehicle
{
    public override async void InsuranceAssessmentAsync()
    {
        using FileStream fstream = new FileStream("TotalOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Транспортные средства не подлежат восстановлению");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");

    }
}

