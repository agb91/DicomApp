using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApplication1
{
    internal class FoldersHandler
    {
        private string folder;

        public FoldersHandler(string folder)
        {
            this.folder = folder;
        }

        public List<String> getSubFolders()
        {
            List<String> subF = new List<String>();
            DirectoryInfo directory = new DirectoryInfo(folder);
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (DirectoryInfo folder in directories)
                subF.Add(folder.Name);

            return subF;
        }
    }
}