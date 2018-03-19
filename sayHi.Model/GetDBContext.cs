using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;


namespace sayHi.Model
{
   public class GetDBContext
    {
        public static sayHiEntities CreateDbContext()
        {
            //强转
            sayHiEntities dbContext = (sayHiEntities)CallContext.GetData("dbContext");
            //如果对象是空的
            if (dbContext == null)
            {
                //则new一个
                dbContext = new sayHiEntities();
                //存储
                CallContext.SetData("dbContext", dbContext);
            }
            //没有为空则直接返回
            return dbContext;
        }
    }
}
