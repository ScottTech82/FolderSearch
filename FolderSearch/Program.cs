
using System.Runtime.CompilerServices;


DisplayAllFolders(@"C:\repos\");

void DisplayAllFolders(string folder, bool displayFiles = false)
{
    string[] folders = Directory.GetDirectories(folder);
    foreach(string f in folders)
    {
        Console.WriteLine(f);
        if (displayFiles)
            DisplayAllFilesInFolder(f);
        DisplayAllFolders(f);
    }
}

void DisplayAllFilesInFolder(string folder)
{
    string[] files = Directory.GetFiles(folder);
    foreach(string file in files)
    {
        Console.WriteLine(file);
    }
}


/*
GetSubFolders();
 
void GetSubFolders()
{
    string foldername = @"C:\repos";
    string[] FolderArray = Directory.GetDirectories(foldername);
    foreach (string folder in FolderArray)
    {
    Console.WriteLine(folder);
        string[] SubFolder = Directory.GetDirectories(folder);
        foreach (string subfolder in SubFolder)
        {
            Console.WriteLine(subfolder);
            string[] Files = Directory.GetFiles(subfolder);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
        }
    }

    
}
*/


//string foldername = @"C:\repos";
//
//
//string[] folders = Directory.GetDirectories(foldername);
//foreach (string folder in folders)
//{
//    Console.WriteLine(folder);
//}
//
//string subfolder = $"C:\\{folder}";
//string[] subfolders = Directory.GetDirectories(subfolder);
//
//
//string FolderFunc(string folder)
//{
//    return folder + FolderFunc(folder + subfolder);
//}
//Console.WriteLine(subfolder);
