
using System;
namespace DesignPattern.Adapter
{
    class CenterInterPreter : BasketballPlayer
    {
        ChineseCenter cc;
        public CenterInterPreter(ChineseCenter cc)
        {
            this.cc = cc;
        }

        public void Attack()
        {
            cc.进攻();
        }
        public void Defense()
        {
            cc.防守();
        }
    }
}