using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using TelephoneInterface;
using Ninject.Web.Common;  // InThreadScope()
namespace Lab_4
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            //Bind<IPhoneDictionary>().To<TelephoneDll_Json.TelephoneContext>().InThreadScope();
            //Bind<IPhoneDictionary>().To<TelephoneDll_SQL.TelephoneContext>().InTransientScope();
            Bind<IPhoneDictionary>().To<TelephoneDll_Json.TelephoneContext>().InTransientScope();
            //Bind<IPhoneDictionary>().To<TelephoneDll_Json.TelephoneContext>().InSingletonScope();

            
        }
    }
}












/*// InTransientScope() - по умолчанию - новый на каждый вызов, каждый раз когда мы будем обращаться(т.е. в любом иесте где будет фигурировать в любом месте будет создаваться новый)
            // InSingletonScope() - паттерн Singleton - один на все вызовы, между вызовами(запросами) сохраняет
            // InThreadScope() - новый экземпляр на каждый поток
            // InRequestScope() - новый экземпляр на каждый запрос(на весь запрос)*/
