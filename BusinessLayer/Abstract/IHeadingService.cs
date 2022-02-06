using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {       // Category'den copy-paste aldım.
        List<Heading> GetList();
        void HeadingAdd(Heading heading);
        Heading GetByID(int id); // GenericRepository'de içini doldurduğum metodu Category Manager'da kullanmak için burda imzamı atıyorum. 
                                  // GenericRepository ve IRepository'de T türünde olduğu için Category türünde olacak fonskiyonum. 
                                  //CategoryManager'a gidiyorum. İmzamı attığım fonskiyonun içini dolduruyorum.
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading); // GenericRepository'de fonksiyon parametre olarak T-> entity(class) p -> parametre
    }
}
