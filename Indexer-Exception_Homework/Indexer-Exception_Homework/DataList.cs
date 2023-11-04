using Indexer_Exception_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exception_Homework
{
    internal class DataList<T>
    {
        private Id[] _idList;
        public DataList()
        {
            _idList = new Id[0];
        }       

        public void Add(Id item)
        {
            Array.Resize(ref _idList, _idList.Length + 1);
            _idList[_idList.Length - 1] = item;
        }

        public void GetById()
        {
            foreach (var data in _idList)
            {
                Console.WriteLine($"{data.ID}");
            }

            
        }
       
    }
}
