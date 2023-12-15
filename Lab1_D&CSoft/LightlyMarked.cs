using System.Text;

namespace Lab1DCSoft;
internal class LightlyMarked : Vehicle
{
    public override async void InsuranceAssessmentAsync()
    {
        using FileStream fstream = new FileStream("LightlyMarkedOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Незначительные повреждения кузовных элементов");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
