using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopApp1.Models;

namespace UiDesktopApp1.interfaces
{
    public interface IDatabase<T> //일반화
    {
        List<T>? Get();

        T? GetDetail(int id);


        void Create(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
