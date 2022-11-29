List<char> cyrillicLetters = new List<char>()
{
    'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х',
    'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
};

int offset = int.Parse(Console.ReadLine()!);
char[] inputStr = Console.ReadLine()!.ToLower().ToArray();

for (int j = 0; j < inputStr.Length; j++)
{
    if (cyrillicLetters.FirstOrDefault(x => x == inputStr[j]) != null)
    {
        inputStr[j] = cyrillicLetters[cyrillicLetters.IndexOf(inputStr[j]) + offset];
    }
}

Console.WriteLine(string.Join("", inputStr));