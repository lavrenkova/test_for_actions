if (Directory.Exists(dirName))
{
    Console.WriteLine("Подкаталоги:");
    string[] dirs = Directory.GetDirectories(dirName);
    foreach (string s in dirs)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    string[] files = Directory.GetFiles(dirName);
    foreach (string s in files)
    {
        Console.WriteLine(s);
	if (s == "paper.md" && s == "paper.pdf" && s == "paper.docx")
		Console.WriteLine("OKAY");
	else
		Console.WriteLine("NOT OKAY");
    }
}
