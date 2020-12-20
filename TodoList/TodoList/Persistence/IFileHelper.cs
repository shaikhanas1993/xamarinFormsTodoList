using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Persistence
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);   
    }
}
