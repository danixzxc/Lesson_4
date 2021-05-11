using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Lesson_4.MyFile;
namespace Lesson_4
{
    class FileDb : BaseDb
    {
        public FileDb()
        {
            Users = new List<Account>(); //переделал через list, чтобы можно было добавлять юзеров
            for (int i = 0; i < GetFile().Length; i=i+2)
            {
                Users.Add(new Account(GetFile()[i], GetFile()[i+1])); //одна строка - логин, следующая - пароль, и так через цикл считываются юзеры из файла
            }
        }
    }
}
