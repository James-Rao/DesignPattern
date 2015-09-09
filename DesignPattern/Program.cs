using DesignPattern.AbstractFactory;
using DesignPattern.Adapter;
using DesignPattern.Builder;
using DesignPattern.Command;
using DesignPattern.Decorator;
using DesignPattern.Facade;
using DesignPattern.Factory;
using DesignPattern.Observer;
using DesignPattern.Prototype;
using DesignPattern.Singleton;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            Console.WriteLine("------------Strategy------------------");
            Console.WriteLine("\r\n ------Strategy Test");
            {
                CashNormal cn = new CashNormal();
                Context ct = new Context(cn);
                ct.PayAmount(100);

                CashDiscount cd = new CashDiscount(0.1);
                ct = new Context(cd);
                ct.PayAmount(100);

                CashReturn cr = new CashReturn(300, 100);
                ct = new Context(cr);
                ct.PayAmount(400);
            }
            #endregion

            #region Observer
            Console.WriteLine("------------Observer------------------");
            Console.WriteLine("\r\n ------Observer Test");
            SydneyStock ss = new SydneyStock();
            StockObserver ob1 = new StockObserver();
            ss.Register(ob1);
            ss.Notify(100);
            ss.Register(new StockObserver());
            ss.Notify(200);
            ss.Unregister(ob1);
            ss.Notify(300);
            #endregion

            #region Factory
            Console.WriteLine("------------Factory------------------");
            Console.WriteLine("\r\n ------Factory Test");
            WarshipFactory wf = new WarshipFactory();
            String s = "A";
            Warship ws = wf.GetWarship(s);
            if (ws != null)
            {
                ws.Fight();
            }
            
            s = "B";
            ws = wf.GetWarship(s);
            if (ws != null)
            {
                ws.Fight();
            }
            #endregion

            #region Abstract Factory
            Console.WriteLine("------------Abstract Factory------------------");
            Console.WriteLine("\r\n ------Abstract Factory Test");
            IRestaurant ir = new ChineseRestaurant();
            IVegetable iv = ir.CookVegetable();
            iv.Display();
            IMeat im = ir.CookMeat();
            im.Display();

            ir = new AustralianRestaurant();
            iv = ir.CookVegetable();
            iv.Display();
            im = ir.CookMeat();
            im.Display();
            #endregion

            #region Singleton
            Console.WriteLine("------------Singleton------------------");
            Console.WriteLine("\r\n ------Singleton Test");
            MySingleton ms1 = MySingleton.GetInstance();
            MySingleton ms2 = MySingleton.GetInstance();
            if (ms1 == ms2)
            {
                Console.WriteLine("Same Instance of Singleton");
            }
            #endregion

            #region Builder
            Console.WriteLine("------------Builder------------------");
            Console.WriteLine("\r\n ------Builder Test");
            {
                IPersonBuilder pb = new FatPersonBuilder();
                PersonBuilderDirector pbd = new PersonBuilderDirector(pb);
                pbd.BuildPerson();
                pbd = new PersonBuilderDirector(new ThinPersonBuilder());
                pbd.BuildPerson();
            }
            #endregion

            #region AdvanceBuilder
            Console.WriteLine("\r\n ------AdvanceBuilder Test");
            {
                PersonBuilderDirectorBase pbd = new PersonBuilderDirector1();
                pbd.SetPersonBuilder(new FatPersonBuilder());
                pbd.BuildPerson();
                pbd.SetPersonBuilder(new ThinPersonBuilder());
                pbd.BuildPerson();
                Console.WriteLine();
                pbd = new PersonBuilderDirector2();
                pbd.SetPersonBuilder(new FatPersonBuilder());
                pbd.BuildPerson();
                pbd.SetPersonBuilder(new ThinPersonBuilder());
                pbd.BuildPerson();
            }
            #endregion

            #region Prototype
            Console.WriteLine("------------Prototype------------------");
            Resume r1 = new Resume();
            r1.id = 1;
            r1.Name = "P1";
            r1.Experience.Company = "C1";
            Console.WriteLine(r1);
            Resume r2 = (Resume)r1.Clone();
            r2.id = 2;
            r2.Name = "P2";
            r2.Experience.Company = "C2";
            Console.WriteLine(r2);
            #endregion

            #region Decorator
            Console.WriteLine("------------Decorator------------------");
            Pizza pp = new PlainPizza();
            ToppingPizza tp = new Mozzarella(pp);
            ToppingPizza ts = new TomatoSauce(tp);
            ts.GetDescription();

            #endregion

            #region Command
            Console.WriteLine("------------Command------------------");
            Cook barbecuerCook = new BarbecuerCook();
            Cook fryDishCook = new FryDishCook();
            Command.Command barbecuerCommand = new BarbecuerCommand(barbecuerCook);
            Command.Command fryDishCommand = new FryDishCommand(fryDishCook);

            Waiter waiter = new Waiter();
            waiter.AddCommand(barbecuerCommand);
            waiter.AddCommand(fryDishCommand);
            waiter.Notify();
            
            #endregion

            #region Adapter
            Console.WriteLine("------------Adapter------------------");
            BasketballPlayer bp1 = new Forward();
            BasketballPlayer bp2 = new Guard();
            ChineseCenter cc = new ChineseCenter();
            BasketballPlayer bp3 = new CenterInterPreter(cc);
            List<BasketballPlayer> bps = new List<BasketballPlayer>();
            bps.Add(bp1);
            bps.Add(bp2);
            bps.Add(bp3);
            foreach (var item in bps)
            {
                item.Attack();
                item.Defense();
            }
            #endregion

            #region Facade
            Console.WriteLine("------------Facade------------------");
            FundFacade ff = new FundFacade();
            ff.Buy();
            ff.Sell();
            #endregion 

            Console.ReadLine();
        }
    }
}
