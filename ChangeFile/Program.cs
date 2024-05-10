using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //这里修改要修改文件的目录
            string path = "C:\\0cda1209\\测试";
            //获取这个路径下的所有文件
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = root.GetFiles();
            List<FileInfo> listFiles = files.ToList();


            for(int i = 0; i < listFiles.Count; i++)
            {
                string fileName = listFiles[i].Name;
                

                bool isHave = fileName.Contains("123");
                if (isHave)
                {
                    //给文件改名字
                    string srcFileName = listFiles[i].FullName;
                    string dstFileName = listFiles[i].Directory.FullName+"/ddd" + listFiles[i].Extension;

                    File.Move(srcFileName, dstFileName);
                }
                Console.WriteLine(fileName);
                Console.WriteLine(isHave);

                //if (listFiles[i].Name == "新建 文本文档.txt")
                //{
                //    System.IO.File.Delete(listFiles[i].FullName);
                //    Console.WriteLine("新建 文本文档.txt已经删除");
                //}

                //Console.WriteLine(listFiles[i].FullName);
                //Console.WriteLine(listFiles[i].Name);
            }


            Console.ReadKey();

        }
    }
}
